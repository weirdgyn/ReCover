using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System.Windows.Forms;

namespace ReCover
{
    public partial class ImageSize : Form
    {
        public decimal PageWidth { get; set; }
        public decimal PageHeight { get; set; }

        public decimal MaxWidth { get; set; }
        public decimal MaxHeight { get; set; }
        public decimal MinWidth { get; set; }
        public decimal MinHeight { get; set; }

        public ImageSize()
        {
            InitializeComponent();

            PageWidth = 0;
            PageHeight = 0;
            MaxWidth = 0;
            MaxHeight = 0;
            MinWidth = 0;
            MinHeight = 0;
        }

        public void UpdateSizes(PdfDocument document, int frontPageIndex, int backPageIndex)
        {
            lvSizes.Items.Clear();

            Rectangle _rect = document.GetDefaultPageSize();

            PageSize _size = PageSizeExtension.SizeOf(_rect);

            ListViewItem _item;

            if (_size != PageSize.Custom)
                _item = new ListViewItem(_size.ToString());
            else
                _item = new ListViewItem(_rect.GetWidth().ToString() + "x" + _rect.GetHeight().ToString());

            MinWidth = MaxWidth = (int)_rect.GetWidth();
            MinHeight = MaxHeight = (int)_rect.GetHeight();

            _item.SubItems.Add("0");
            _item.SubItems.Add(_rect.GetWidth().ToString());
            _item.SubItems.Add(_rect.GetHeight().ToString());

            lvSizes.Items.Add(_item);

            for (int _i = 0; _i < document.GetNumberOfPages(); _i++)
            {
                PdfPage _page = document.GetPage(_i + 1);

                _rect = _page.GetPageSize();

                _size = PageSizeExtension.SizeOf(_rect);

                string _text;

                if (_size != PageSize.Custom)
                    _text = _size.ToString();
                else
                    _text = _rect.GetWidth().ToString() + "x" + _rect.GetHeight().ToString();

                _item = lvSizes.FindItemWithText(_text);

                if (_item != null)
                {
                    int _count = int.Parse(_item.SubItems[1].Text);
                    _count++;
                    _item.SubItems[1].Text = _count.ToString();
                }
                else
                {
                    if (_size != PageSize.Custom)
                        _item = new ListViewItem(_size.ToString());
                    else
                        _item = new ListViewItem(_text);

                    _item.SubItems.Add("1");
                    _item.SubItems.Add(_rect.GetWidth().ToString());
                    _item.SubItems.Add(_rect.GetHeight().ToString());

                    lvSizes.Items.Add(_item);
                }

                if (_i+1 == frontPageIndex)
                    if (_item.SubItems.Count == 4)
                        _item.SubItems.Add("Front");

                if (_i+1 == backPageIndex)
                    if (_item.SubItems.Count == 4)
                        _item.SubItems.Add("Back");
 
                if ((decimal)_rect.GetWidth() > MaxWidth)
                    MaxWidth = (decimal)_rect.GetWidth();

                if ((decimal)_rect.GetHeight() > MaxHeight)
                    MaxHeight = (decimal)_rect.GetHeight();

                if ((decimal)_rect.GetWidth() < MinWidth)
                    MinWidth = (decimal)_rect.GetWidth();

                if ((decimal)_rect.GetHeight() < MinHeight)
                    MinHeight = (decimal)_rect.GetHeight();
            }

            lvSizes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Confirm()
        {
            var items = lvSizes.SelectedItems;

            if (items.Count == 0)
                return;

            PageWidth = decimal.Parse(items[0].SubItems[2].Text.ToString());
            PageHeight = decimal.Parse(items[0].SubItems[3].Text.ToString());

            DialogResult = DialogResult.OK;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Confirm();
        }

        private void lvSizes_DoubleClick(object sender, System.EventArgs e)
        {
            Confirm();

            Close();
        }
    }
}
