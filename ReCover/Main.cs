using Ghostscript.NET;
using Ghostscript.NET.Rasterizer;
using iText.Kernel.Pdf;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ReCover
{
    public partial class Main : Form
    {
        private ImageSize dlgImageSize = new ImageSize();
        private ToolTip pictureToolTip = new ToolTip();

        private PreviewMode frontMode = PreviewMode.Source;
        private PreviewMode backMode = PreviewMode.Source;

        public Main()
        {
            InitializeComponent();

            ofdOpenFile.Filter = Properties.Resources.PDF_FILES_Filter + "|" + Properties.Resources.IMG_FILES_Filter;

            pictureToolTip.AutoPopDelay = 2000;
            pictureToolTip.InitialDelay = 1000;
            pictureToolTip.ReshowDelay = 500;
            pictureToolTip.ShowAlways = false;
        }

        private void SetText(TextBox textBox, string text)
        {
            textBox.Text = text;
        }

        private void SetTextAsync(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
                textBox.Invoke(new Action<TextBox, string>(SetText), textBox, text);
            else
                SetText(textBox, text);
        }

        private async void SetTextFromUrl(TextBox textBox, string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var data = await client.GetByteArrayAsync(url);

                    using (var buffer = new MemoryStream(data))
                    {
                        string filename = null;
                        var guid = Guid.NewGuid().ToString();

                        var temp = Path.GetTempPath();

                        if (isImage(url))
                        {
                            var image = Image.FromStream(buffer);

                            filename = Path.Combine(temp, guid + Properties.Resources.BMP_EXT);

                            image.Save(filename);
                        }
                        else if (url.EndsWith(Properties.Resources.PDF_EXT, true, System.Globalization.CultureInfo.InvariantCulture))
                        {
                            filename = Path.Combine(temp, guid + Properties.Resources.PDF_EXT);

                            File.WriteAllBytes(filename, buffer.ToArray());
                        }

                        if (!string.IsNullOrEmpty(filename))
                            SetTextAsync(textBox, filename);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void SetImage(PictureBox pBox, string file, int page, int dpi = 100)
        {
            using (var rasterizer = new GhostscriptRasterizer())
            {
                var versionInfo = new GhostscriptVersionInfo(
                    new Version(0, 0, 0),
                    Properties.Settings.Default.GSDLL,
                    string.Empty,
                    GhostscriptLicense.GPL
                );

                rasterizer.Open(file, versionInfo, false);

                if (page <= rasterizer.PageCount)
                {
                    var img = rasterizer.GetPage(dpi, page);

                    pBox.Image = img;
                }

                rasterizer.Close();
            }
        }

        public void SetImage(PictureBox pBox, string file)
        {
            Image image = Image.FromFile(file);
            pBox.Image = image;
        }

        public void UpdateFrontPreview()
        {
            switch (frontMode)
            {
                case PreviewMode.New:
                    SetImage(pbFrontPicture, txtFrontPicture.Text);
                    break;
                case PreviewMode.Source:
                    if (nudFrontPage.Value != 0)
                        SetImage(pbFrontPicture, txtSource.Text, (int)nudFrontPage.Value);
                    else
                        pbFrontPicture.Image = null;
                    break;
            }
        }

        public void UpdateBackPreview()
        {
            switch (backMode)
            {
                case PreviewMode.New:
                    SetImage(pbBackPicture, txtBackPicture.Text);
                    break;
                case PreviewMode.Source:
                    if (nudBackPage.Value != 0)
                        SetImage(pbBackPicture, txtSource.Text, (int)nudBackPage.Value);
                    else
                        pbFrontPicture.Image = null;
                    break;
            }
        }

        private bool isImage(string path)
        {
            return path.EndsWith("jpg", StringComparison.InvariantCultureIgnoreCase) ||
                path.EndsWith("png", StringComparison.InvariantCultureIgnoreCase) ||
                path.EndsWith("gif", StringComparison.InvariantCultureIgnoreCase) ||
                path.EndsWith("tiff", StringComparison.InvariantCultureIgnoreCase) ||
                path.EndsWith("bmp", StringComparison.InvariantCultureIgnoreCase);
        }

        private void DrawMode(PaintEventArgs e, PreviewMode mode)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            e.Graphics.DrawString(
                mode.ToString(),
                Font,
                Brushes.Blue,
                0, 0);
        }

        private string CreateDoc(string source, decimal width, decimal height)
        {
            string filename = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(source) + ".pdf");

            using (var writer = new PdfWriter(filename))
            {
                using (var pdfDocument = new PdfDocument(writer))
                {
                    iText.Kernel.Geom.Rectangle rectangle = new iText.Kernel.Geom.Rectangle(0, 0, (int)width, (int)height);

                    iText.Layout.Element.Image image = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(source));

                    // Image is scaled to the document size (best fit)

                    if (rectangle != null)
                        image.ScaleToFit(
                            rectangle.GetWidth(),
                            rectangle.GetHeight());

                    // To avoid borders the document size is clipped to the image after the image scaling

                    double imageWidth = image.GetImageScaledWidth();
                    double imageHeight = image.GetImageScaledHeight();

                    rectangle.SetWidth((int)imageWidth);
                    rectangle.SetHeight((int)imageHeight);

                    iText.Layout.Document document = new iText.Layout.Document(pdfDocument, new iText.Kernel.Geom.PageSize(rectangle));

                    document.SetMargins(0, 0, 0, 0);

                    document.Add(image);
                }
            }

            return filename;
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            ofdOpenFile.DefaultExt = Properties.Resources.DEF_PDF_Filter;
            ofdOpenFile.FilterIndex = int.Parse(Properties.Resources.PDF_FilterIndex);

            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                SetText(txtSource, ofdOpenFile.FileName);
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                SetText(txtDestination, sfdSaveFile.FileName);
            }
        }

        private void btnSelectFront_Click(object sender, EventArgs e)
        {
            ofdOpenFile.DefaultExt = Properties.Resources.DEF_IMG_Filter;
            ofdOpenFile.FilterIndex = int.Parse(Properties.Resources.IMG_FilterIndex);

            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                SetText(txtFrontPicture, ofdOpenFile.FileName);
            }
        }

        private void btnSelectBack_Click(object sender, EventArgs e)
        {
            ofdOpenFile.DefaultExt = Properties.Resources.DEF_IMG_Filter;
            ofdOpenFile.FilterIndex = int.Parse(Properties.Resources.IMG_FilterIndex);

            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                SetText(txtBackPicture, ofdOpenFile.FileName);
            }
        }

        private void btnSelectFrontSize_Click(object sender, EventArgs e)
        {
            if (dlgImageSize.ShowDialog() == DialogResult.OK)
            {
                nudFrontWidth.Value = dlgImageSize.PageWidth;
                nudFrontHeight.Value = dlgImageSize.PageHeight;
            }
        }

        private void btnSelectBackSize_Click(object sender, EventArgs e)
        {
            if (dlgImageSize.ShowDialog() == DialogResult.OK)
            {
                nudBackWidth.Value = dlgImageSize.PageWidth;
                nudBackHeight.Value = dlgImageSize.PageHeight;
            }
        }

        private void nudFrontPage_ValueChanged(object sender, EventArgs e)
        {
            if (frontMode.Equals(PreviewMode.Source))
                UpdateFrontPreview();
        }

        private void nudBackPage_ValueChanged(object sender, EventArgs e)
        {
            if (backMode.Equals(PreviewMode.Source))
                UpdateBackPreview();
        }

        private void txtSource_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtSource_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                SetText(txtSource, files[0]);
            }
        }

        private void txtFrontPicture_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                SetText(txtFrontPicture, files[0]);
            }
            else if (e.Data.GetDataPresent(Properties.Resources.URL_MIME))
            {
                var data = (MemoryStream)e.Data.GetData(Properties.Resources.URL_MIME);

                var url = Encoding.Unicode.GetString(data.ToArray()).Trim('\n', '\0');

                SetTextFromUrl(txtFrontPicture, url);
            }
        }

        private void txtBackPicture_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                SetText(txtBackPicture, files[0]);
            }
            else if (e.Data.GetDataPresent(Properties.Resources.URL_MIME))
            {
                var data = (MemoryStream)e.Data.GetData(Properties.Resources.URL_MIME);

                var url = Encoding.Unicode.GetString(data.ToArray()).Trim('\n', '\0');

                SetTextFromUrl(txtBackPicture, url);
            }
        }

        private void txtDestination_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtDestination_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                SetText(txtDestination, files[0]);
            }
        }

        private void txtFrontPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(Properties.Resources.URL_MIME))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtBackPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(Properties.Resources.URL_MIME))
                e.Effect = DragDropEffects.Copy;
        }
        
        private void btnLoadSource_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtSource.Text))
                return;

            using (var reader = new PdfReader(txtSource.Text))
            {
                using (var document = new PdfDocument(reader))
                {
                    nudBackPage.Maximum = nudFrontPage.Maximum = document.GetNumberOfPages();

                    nudFrontPage.Value = 1;
                    nudBackPage.Value = nudBackPage.Maximum;

                    dlgImageSize.UpdateSizes(document, (int)nudFrontPage.Value, (int)nudBackPage.Value);

                    nudBackWidth.Maximum = nudFrontWidth.Maximum = dlgImageSize.MaxWidth;
                    nudBackHeight.Maximum = nudFrontHeight.Maximum = dlgImageSize.MaxHeight;

                    nudBackWidth.Minimum = nudFrontWidth.Minimum = dlgImageSize.MinWidth;
                    nudBackHeight.Minimum = nudFrontHeight.Minimum = dlgImageSize.MinHeight;
                }
            }
        }

        private void txtFrontPicture_TextChanged(object sender, EventArgs e)
        {
            if (frontMode == PreviewMode.New)
                UpdateFrontPreview();
        }

        private void txtBackPicture_TextChanged(object sender, EventArgs e)
        {
            if (backMode == PreviewMode.New)
                UpdateBackPreview();
        }

        private void pbFrontPicture_Click(object sender, EventArgs e)
        {
            frontMode = ((frontMode == PreviewMode.Source) ? PreviewMode.New : PreviewMode.Source);
            UpdateFrontPreview();
        }

        private void pbBackPicture_Click(object sender, EventArgs e)
        {
            backMode = ((backMode == PreviewMode.Source) ? PreviewMode.New : PreviewMode.Source);
            UpdateBackPreview();
        }

        private void btnSaveDestination_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDestination.Text))
                return;

            if (string.IsNullOrEmpty(txtSource.Text))
                return;

            string frontPageFile = "";

            if (nudFrontPage.Value != 0)
            { 
                if (isImage(txtFrontPicture.Text))
                    frontPageFile = CreateDoc(txtFrontPicture.Text, nudFrontWidth.Value, nudFrontHeight.Value);
                else
                    frontPageFile = txtFrontPicture.Text;
            }

            string backPageFile = "";

            if (nudBackPage.Value != 0) 
            {
                if (isImage(txtBackPicture.Text))
                    backPageFile = CreateDoc(txtBackPicture.Text, nudBackWidth.Value, nudBackHeight.Value);
                else
                    backPageFile = txtBackPicture.Text;
            }

            var filename = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".pdf");

            using (var destination = new PdfDocument(new PdfReader(txtSource.Text), new PdfWriter(filename)))
            {
                if (!string.IsNullOrEmpty(frontPageFile) && File.Exists(frontPageFile))
                {
                    if (cbBackupFront.Checked)
                    {
                        var backupFrontFilename = Path.Combine(Properties.Settings.Default.BackupFolder, nudFrontPage.Value.ToString()+".pdf");
                        
                        using (var backupFront = new PdfDocument(new PdfWriter(backupFrontFilename)))
                        {
                            using (PdfDocument source = new PdfDocument(new PdfReader(txtSource.Text)))
                            {
                                source.CopyPagesTo(1, 1, backupFront, (int)nudFrontPage.Value);
                            }
                        }
                    }

                    destination.RemovePage((int)nudFrontPage.Value);

                    using (PdfDocument frontPage = new PdfDocument(new PdfReader(frontPageFile)))
                    {
                        frontPage.CopyPagesTo(1, 1, destination, (int)nudFrontPage.Value);
                    }
                }

                if (!string.IsNullOrEmpty(backPageFile) && File.Exists(backPageFile))
                {
                    if (cbBackupBack.Checked)
                    {
                        var backupBackFilename = Path.Combine(Properties.Settings.Default.BackupFolder, nudBackPage.Value.ToString() + ".pdf");

                        using (var backupBack = new PdfDocument(new PdfWriter(backupBackFilename)))
                        {
                            using (PdfDocument source = new PdfDocument(new PdfReader(txtSource.Text)))
                            {
                                source.CopyPagesTo(1, 1, backupBack, (int)nudBackPage.Value);
                            }
                        }
                    }

                    destination.RemovePage((int)nudBackPage.Value);

                    using (PdfDocument backPage = new PdfDocument(new PdfReader(backPageFile)))
                    {
                        backPage.CopyPagesTo(1, 1, destination, (int)nudBackPage.Value);
                    }
                }
            }

            if (File.Exists(txtDestination.Text))
                    File.Delete(txtDestination.Text);

            File.Move(filename, txtDestination.Text);
        }

        private void pbFrontPicture_Paint(object sender, PaintEventArgs e)
        {
            DrawMode(e, frontMode);
        }

        private void pbBackPicture_Paint(object sender, PaintEventArgs e)
        {
            DrawMode(e, backMode);
        }

        private void pbFrontPicture_MouseEnter(object sender, EventArgs e)
        {
            if (pbFrontPicture.Image == null)
            { 
                pictureToolTip.SetToolTip(pbFrontPicture, string.Empty);
                return;
            }

            pictureToolTip.SetToolTip(pbFrontPicture, string.Format("{0}x{1}", pbFrontPicture.Image.Width, pbFrontPicture.Image.Height));
        }

        private void pbBackPicture_MouseEnter(object sender, EventArgs e)
        {
            if (pbBackPicture.Image == null)
            {
                pictureToolTip.SetToolTip(pbBackPicture, string.Empty);
                return;
            }

            pictureToolTip.SetToolTip(pbBackPicture, string.Format("{0}x{1}", pbBackPicture.Image.Width, pbBackPicture.Image.Height));
        }
    }
}
