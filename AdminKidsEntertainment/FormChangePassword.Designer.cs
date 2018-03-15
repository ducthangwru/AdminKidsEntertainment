namespace AdminKidsEntertainment
{
    partial class FormChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.txbXacNhanMK = new DevExpress.XtraEditors.TextEdit();
            this.txbMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txbMatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.peXacNhanMK = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txbXacNhanMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peXacNhanMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(139, 184);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMK.TabIndex = 14;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txbXacNhanMK
            // 
            this.txbXacNhanMK.Location = new System.Drawing.Point(139, 134);
            this.txbXacNhanMK.Name = "txbXacNhanMK";
            this.txbXacNhanMK.Properties.UseSystemPasswordChar = true;
            this.txbXacNhanMK.Size = new System.Drawing.Size(156, 20);
            this.txbXacNhanMK.TabIndex = 13;
            this.txbXacNhanMK.EditValueChanged += new System.EventHandler(this.txbXacNhanMK_EditValueChanged_1);
            this.txbXacNhanMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbXacNhanMK_KeyDown);
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(139, 90);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Properties.UseSystemPasswordChar = true;
            this.txbMatKhauMoi.Size = new System.Drawing.Size(156, 20);
            this.txbMatKhauMoi.TabIndex = 12;
            this.txbMatKhauMoi.EditValueChanged += new System.EventHandler(this.txbMatKhauMoi_EditValueChanged);
            this.txbMatKhauMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMatKhauMoi_KeyDown);
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(139, 47);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Properties.UseSystemPasswordChar = true;
            this.txbMatKhauCu.Size = new System.Drawing.Size(156, 20);
            this.txbMatKhauCu.TabIndex = 11;
            this.txbMatKhauCu.EditValueChanged += new System.EventHandler(this.txbXacNhanMK_EditValueChanged);
            this.txbMatKhauCu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMatKhauCu_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Xác nhận mật khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // peXacNhanMK
            // 
            this.peXacNhanMK.EditValue = global::AdminKidsEntertainment.Properties.Resources.cancel_32x32;
            this.peXacNhanMK.Location = new System.Drawing.Point(312, 132);
            this.peXacNhanMK.Name = "peXacNhanMK";
            this.peXacNhanMK.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peXacNhanMK.Size = new System.Drawing.Size(22, 22);
            this.peXacNhanMK.TabIndex = 15;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 235);
            this.Controls.Add(this.peXacNhanMK);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txbXacNhanMK);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.txbMatKhauCu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txbXacNhanMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMatKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peXacNhanMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peXacNhanMK;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private DevExpress.XtraEditors.TextEdit txbXacNhanMK;
        private DevExpress.XtraEditors.TextEdit txbMatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txbMatKhauCu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}