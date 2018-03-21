namespace AdminKidsEntertainment
{
    partial class FormQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQRCode));
            this.dialogSaveFile = new System.Windows.Forms.FolderBrowserDialog();
            this.dialogUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.peQR = new DevExpress.XtraEditors.PictureEdit();
            this.btnChooseImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnImageText = new DevExpress.XtraEditors.SimpleButton();
            this.btnQRText = new DevExpress.XtraEditors.SimpleButton();
            this.teURL = new DevExpress.XtraEditors.TextEdit();
            this.meMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.peAnhURL = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.peQR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAnhURL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // peQR
            // 
            this.peQR.Location = new System.Drawing.Point(546, 46);
            this.peQR.Name = "peQR";
            this.peQR.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peQR.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peQR.Size = new System.Drawing.Size(300, 300);
            this.peQR.TabIndex = 0;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(270, 71);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(104, 23);
            this.btnChooseImage.TabIndex = 2;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnImageText
            // 
            this.btnImageText.Location = new System.Drawing.Point(39, 269);
            this.btnImageText.Name = "btnImageText";
            this.btnImageText.Size = new System.Drawing.Size(138, 23);
            this.btnImageText.TabIndex = 3;
            this.btnImageText.Text = "QR Hình ảnh + chữ";
            this.btnImageText.Click += new System.EventHandler(this.btnImageText_Click);
            // 
            // btnQRText
            // 
            this.btnQRText.Location = new System.Drawing.Point(236, 269);
            this.btnQRText.Name = "btnQRText";
            this.btnQRText.Size = new System.Drawing.Size(137, 23);
            this.btnQRText.TabIndex = 4;
            this.btnQRText.Text = "QR chữ";
            this.btnQRText.Click += new System.EventHandler(this.btnQRText_Click);
            // 
            // teURL
            // 
            this.teURL.Location = new System.Drawing.Point(134, 45);
            this.teURL.Name = "teURL";
            this.teURL.Size = new System.Drawing.Size(240, 20);
            this.teURL.TabIndex = 5;
            this.teURL.EditValueChanged += new System.EventHandler(this.teURL_EditValueChanged);
            // 
            // meMoTa
            // 
            this.meMoTa.Location = new System.Drawing.Point(134, 103);
            this.meMoTa.Name = "meMoTa";
            this.meMoTa.Size = new System.Drawing.Size(240, 96);
            this.meMoTa.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Đường dẫn ảnh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Nội dung";
            // 
            // peAnhURL
            // 
            this.peAnhURL.Location = new System.Drawing.Point(414, 48);
            this.peAnhURL.Name = "peAnhURL";
            this.peAnhURL.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAnhURL.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peAnhURL.Size = new System.Drawing.Size(100, 100);
            this.peAnhURL.TabIndex = 9;
            // 
            // FormQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 431);
            this.Controls.Add(this.peAnhURL);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.meMoTa);
            this.Controls.Add(this.teURL);
            this.Controls.Add(this.btnQRText);
            this.Controls.Add(this.btnImageText);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.peQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQRCode";
            this.Text = "QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.peQR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAnhURL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dialogSaveFile;
        private System.Windows.Forms.OpenFileDialog dialogUploadFile;
        private DevExpress.XtraEditors.PictureEdit peQR;
        private DevExpress.XtraEditors.SimpleButton btnChooseImage;
        private DevExpress.XtraEditors.SimpleButton btnImageText;
        private DevExpress.XtraEditors.SimpleButton btnQRText;
        private DevExpress.XtraEditors.TextEdit teURL;
        private DevExpress.XtraEditors.MemoEdit meMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit peAnhURL;
    }
}