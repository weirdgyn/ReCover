namespace ReCover
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFrontPicture = new System.Windows.Forms.PictureBox();
            this.pbBackPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtFrontPicture = new System.Windows.Forms.TextBox();
            this.txtBackPicture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectFront = new System.Windows.Forms.Button();
            this.btnSelectBack = new System.Windows.Forms.Button();
            this.nudFrontPage = new System.Windows.Forms.NumericUpDown();
            this.nudBackPage = new System.Windows.Forms.NumericUpDown();
            this.nudFrontWidth = new System.Windows.Forms.NumericUpDown();
            this.nudFrontHeight = new System.Windows.Forms.NumericUpDown();
            this.nudBackHeight = new System.Windows.Forms.NumericUpDown();
            this.nudBackWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectFrontSize = new System.Windows.Forms.Button();
            this.btnSelectBackSize = new System.Windows.Forms.Button();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.btnSaveDestination = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.AllowDrop = true;
            this.txtSource.Location = new System.Drawing.Point(68, 6);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(375, 22);
            this.txtSource.TabIndex = 0;
            this.txtSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSource_DragDrop);
            this.txtSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtSource_DragEnter);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.AllowDrop = true;
            this.btnSelectSource.Location = new System.Drawing.Point(486, 6);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(31, 23);
            this.btnSelectSource.TabIndex = 1;
            this.btnSelectSource.Text = "...";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            this.btnSelectSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSource_DragDrop);
            this.btnSelectSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtSource_DragEnter);
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.DefaultExt = "*.pdf";
            this.sfdSaveFile.Filter = "PDF file|*.pdf";
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.DefaultExt = "*.pdf";
            this.ofdOpenFile.Filter = "PDF files|*.pdf|JPG images|*.jpg|PNG images|*.png|BMP images|*.bmp|TIFF images|*." +
    "tiff|GIF images|*.gif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // pbFrontPicture
            // 
            this.pbFrontPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFrontPicture.Location = new System.Drawing.Point(12, 62);
            this.pbFrontPicture.Name = "pbFrontPicture";
            this.pbFrontPicture.Size = new System.Drawing.Size(242, 207);
            this.pbFrontPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFrontPicture.TabIndex = 3;
            this.pbFrontPicture.TabStop = false;
            this.pbFrontPicture.Click += new System.EventHandler(this.pbFrontPicture_Click);
            // 
            // pbBackPicture
            // 
            this.pbBackPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackPicture.Location = new System.Drawing.Point(260, 62);
            this.pbBackPicture.Name = "pbBackPicture";
            this.pbBackPicture.Size = new System.Drawing.Size(250, 207);
            this.pbBackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackPicture.TabIndex = 4;
            this.pbBackPicture.TabStop = false;
            this.pbBackPicture.Click += new System.EventHandler(this.pbBackPicture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination";
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.AllowDrop = true;
            this.btnSelectDestination.Location = new System.Drawing.Point(479, 336);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(31, 23);
            this.btnSelectDestination.TabIndex = 13;
            this.btnSelectDestination.Text = "...";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            this.btnSelectDestination.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDestination_DragDrop);
            this.btnSelectDestination.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDestination_DragEnter);
            // 
            // txtDestination
            // 
            this.txtDestination.AllowDrop = true;
            this.txtDestination.Location = new System.Drawing.Point(89, 337);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(347, 22);
            this.txtDestination.TabIndex = 12;
            this.txtDestination.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDestination_DragDrop);
            this.txtDestination.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDestination_DragEnter);
            // 
            // txtFrontPicture
            // 
            this.txtFrontPicture.AllowDrop = true;
            this.txtFrontPicture.Location = new System.Drawing.Point(12, 275);
            this.txtFrontPicture.Name = "txtFrontPicture";
            this.txtFrontPicture.Size = new System.Drawing.Size(205, 22);
            this.txtFrontPicture.TabIndex = 4;
            this.txtFrontPicture.TextChanged += new System.EventHandler(this.txtFrontPicture_TextChanged);
            this.txtFrontPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFrontPicture_DragDrop);
            this.txtFrontPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFrontPicture_DragEnter);
            // 
            // txtBackPicture
            // 
            this.txtBackPicture.AllowDrop = true;
            this.txtBackPicture.Location = new System.Drawing.Point(260, 275);
            this.txtBackPicture.Name = "txtBackPicture";
            this.txtBackPicture.Size = new System.Drawing.Size(213, 22);
            this.txtBackPicture.TabIndex = 6;
            this.txtBackPicture.TextChanged += new System.EventHandler(this.txtBackPicture_TextChanged);
            this.txtBackPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtBackPicture_DragDrop);
            this.txtBackPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtBackPicture_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Front";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Back";
            // 
            // btnSelectFront
            // 
            this.btnSelectFront.AllowDrop = true;
            this.btnSelectFront.Location = new System.Drawing.Point(223, 274);
            this.btnSelectFront.Name = "btnSelectFront";
            this.btnSelectFront.Size = new System.Drawing.Size(31, 23);
            this.btnSelectFront.TabIndex = 5;
            this.btnSelectFront.Text = "...";
            this.btnSelectFront.UseVisualStyleBackColor = true;
            this.btnSelectFront.Click += new System.EventHandler(this.btnSelectFront_Click);
            this.btnSelectFront.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFrontPicture_DragDrop);
            this.btnSelectFront.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFrontPicture_DragEnter);
            // 
            // btnSelectBack
            // 
            this.btnSelectBack.AllowDrop = true;
            this.btnSelectBack.Location = new System.Drawing.Point(479, 275);
            this.btnSelectBack.Name = "btnSelectBack";
            this.btnSelectBack.Size = new System.Drawing.Size(31, 23);
            this.btnSelectBack.TabIndex = 7;
            this.btnSelectBack.Text = "...";
            this.btnSelectBack.UseVisualStyleBackColor = true;
            this.btnSelectBack.Click += new System.EventHandler(this.btnSelectBack_Click);
            this.btnSelectBack.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtBackPicture_DragDrop);
            this.btnSelectBack.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtBackPicture_DragEnter);
            // 
            // nudFrontPage
            // 
            this.nudFrontPage.Location = new System.Drawing.Point(52, 34);
            this.nudFrontPage.Name = "nudFrontPage";
            this.nudFrontPage.Size = new System.Drawing.Size(206, 22);
            this.nudFrontPage.TabIndex = 2;
            this.nudFrontPage.ValueChanged += new System.EventHandler(this.nudFrontPage_ValueChanged);
            // 
            // nudBackPage
            // 
            this.nudBackPage.Location = new System.Drawing.Point(305, 34);
            this.nudBackPage.Name = "nudBackPage";
            this.nudBackPage.Size = new System.Drawing.Size(212, 22);
            this.nudBackPage.TabIndex = 3;
            this.nudBackPage.ValueChanged += new System.EventHandler(this.nudBackPage_ValueChanged);
            // 
            // nudFrontWidth
            // 
            this.nudFrontWidth.DecimalPlaces = 2;
            this.nudFrontWidth.Location = new System.Drawing.Point(54, 303);
            this.nudFrontWidth.Name = "nudFrontWidth";
            this.nudFrontWidth.Size = new System.Drawing.Size(80, 22);
            this.nudFrontWidth.TabIndex = 8;
            // 
            // nudFrontHeight
            // 
            this.nudFrontHeight.DecimalPlaces = 2;
            this.nudFrontHeight.Location = new System.Drawing.Point(140, 303);
            this.nudFrontHeight.Name = "nudFrontHeight";
            this.nudFrontHeight.Size = new System.Drawing.Size(80, 22);
            this.nudFrontHeight.TabIndex = 9;
            // 
            // nudBackHeight
            // 
            this.nudBackHeight.DecimalPlaces = 2;
            this.nudBackHeight.Location = new System.Drawing.Point(391, 303);
            this.nudBackHeight.Name = "nudBackHeight";
            this.nudBackHeight.Size = new System.Drawing.Size(80, 22);
            this.nudBackHeight.TabIndex = 11;
            // 
            // nudBackWidth
            // 
            this.nudBackWidth.DecimalPlaces = 2;
            this.nudBackWidth.Location = new System.Drawing.Point(305, 303);
            this.nudBackWidth.Name = "nudBackWidth";
            this.nudBackWidth.Size = new System.Drawing.Size(80, 22);
            this.nudBackWidth.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "WxH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "WxH";
            // 
            // btnSelectFrontSize
            // 
            this.btnSelectFrontSize.Location = new System.Drawing.Point(223, 303);
            this.btnSelectFrontSize.Name = "btnSelectFrontSize";
            this.btnSelectFrontSize.Size = new System.Drawing.Size(31, 23);
            this.btnSelectFrontSize.TabIndex = 24;
            this.btnSelectFrontSize.TabStop = false;
            this.btnSelectFrontSize.Text = "?";
            this.btnSelectFrontSize.UseVisualStyleBackColor = true;
            this.btnSelectFrontSize.Click += new System.EventHandler(this.btnSelectFrontSize_Click);
            // 
            // btnSelectBackSize
            // 
            this.btnSelectBackSize.Location = new System.Drawing.Point(479, 303);
            this.btnSelectBackSize.Name = "btnSelectBackSize";
            this.btnSelectBackSize.Size = new System.Drawing.Size(31, 23);
            this.btnSelectBackSize.TabIndex = 25;
            this.btnSelectBackSize.TabStop = false;
            this.btnSelectBackSize.Text = "?";
            this.btnSelectBackSize.UseVisualStyleBackColor = true;
            this.btnSelectBackSize.Click += new System.EventHandler(this.btnSelectBackSize_Click);
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Location = new System.Drawing.Point(449, 6);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(31, 23);
            this.btnLoadSource.TabIndex = 26;
            this.btnLoadSource.TabStop = false;
            this.btnLoadSource.Text = "L";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // btnSaveDestination
            // 
            this.btnSaveDestination.Location = new System.Drawing.Point(442, 336);
            this.btnSaveDestination.Name = "btnSaveDestination";
            this.btnSaveDestination.Size = new System.Drawing.Size(31, 23);
            this.btnSaveDestination.TabIndex = 27;
            this.btnSaveDestination.TabStop = false;
            this.btnSaveDestination.Text = "S";
            this.btnSaveDestination.UseVisualStyleBackColor = true;
            this.btnSaveDestination.Click += new System.EventHandler(this.btnSaveDestination_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 370);
            this.Controls.Add(this.btnSaveDestination);
            this.Controls.Add(this.btnLoadSource);
            this.Controls.Add(this.btnSelectBackSize);
            this.Controls.Add(this.btnSelectFrontSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudBackHeight);
            this.Controls.Add(this.nudBackWidth);
            this.Controls.Add(this.nudFrontHeight);
            this.Controls.Add(this.nudFrontWidth);
            this.Controls.Add(this.nudBackPage);
            this.Controls.Add(this.nudFrontPage);
            this.Controls.Add(this.btnSelectBack);
            this.Controls.Add(this.btnSelectFront);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBackPicture);
            this.Controls.Add(this.txtFrontPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.pbBackPicture);
            this.Controls.Add(this.pbFrontPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "PDF ReCover";
            ((System.ComponentModel.ISupportInitialize)(this.pbFrontPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrontHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFrontPicture;
        private System.Windows.Forms.PictureBox pbBackPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtFrontPicture;
        private System.Windows.Forms.TextBox txtBackPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectFront;
        private System.Windows.Forms.Button btnSelectBack;
        private System.Windows.Forms.NumericUpDown nudFrontPage;
        private System.Windows.Forms.NumericUpDown nudBackPage;
        private System.Windows.Forms.NumericUpDown nudFrontWidth;
        private System.Windows.Forms.NumericUpDown nudFrontHeight;
        private System.Windows.Forms.NumericUpDown nudBackHeight;
        private System.Windows.Forms.NumericUpDown nudBackWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectFrontSize;
        private System.Windows.Forms.Button btnSelectBackSize;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.Button btnSaveDestination;
    }
}

