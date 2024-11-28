namespace ReCover
{
    partial class ImageSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvSizes = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 281);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(251, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lvSizes
            // 
            this.lvSizes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chCount,
            this.chWidth,
            this.chHeight});
            this.lvSizes.FullRowSelect = true;
            this.lvSizes.HideSelection = false;
            this.lvSizes.Location = new System.Drawing.Point(12, 12);
            this.lvSizes.Name = "lvSizes";
            this.lvSizes.Size = new System.Drawing.Size(314, 263);
            this.lvSizes.TabIndex = 4;
            this.lvSizes.UseCompatibleStateImageBehavior = false;
            this.lvSizes.View = System.Windows.Forms.View.Details;
            this.lvSizes.DoubleClick += new System.EventHandler(this.lvSizes_DoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chCount
            // 
            this.chCount.Text = "Count";
            // 
            // chWidth
            // 
            this.chWidth.Text = "Width";
            // 
            // chHeight
            // 
            this.chHeight.Text = "Height";
            // 
            // ImageSize
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(338, 316);
            this.Controls.Add(this.lvSizes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImageSize";
            this.Text = "ImageSize";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvSizes;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chCount;
        private System.Windows.Forms.ColumnHeader chWidth;
        private System.Windows.Forms.ColumnHeader chHeight;
    }
}