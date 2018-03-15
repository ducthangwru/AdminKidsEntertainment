namespace AdminKidsEntertainment
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupQuanLy = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupLichSu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupThongKe = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.iKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.popupBaoCao = new DevExpress.XtraBars.PopupMenu(this.components);
            this.iBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnQlyVideo = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnQRCode = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // appMenu
            // 
            this.appMenu.Name = "appMenu";
            this.appMenu.ShowRightPane = true;
            // 
            // popupQuanLy
            // 
            this.popupQuanLy.Name = "popupQuanLy";
            // 
            // popupLichSu
            // 
            this.popupLichSu.Name = "popupLichSu";
            // 
            // popupThongKe
            // 
            this.popupThongKe.Name = "popupThongKe";
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            // 
            // iKhachHang
            // 
            this.iKhachHang.Caption = "Khách hàng";
            this.iKhachHang.Description = "Khách hàng";
            this.iKhachHang.Id = 17;
            this.iKhachHang.ImageIndex = 5;
            this.iKhachHang.LargeImageIndex = 4;
            this.iKhachHang.Name = "iKhachHang";
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // popupBaoCao
            // 
            this.popupBaoCao.Name = "popupBaoCao";
            // 
            // iBaoCao
            // 
            this.iBaoCao.ActAsDropDown = true;
            this.iBaoCao.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iBaoCao.Caption = "Báo cáo";
            this.iBaoCao.Description = "Báo cáo";
            this.iBaoCao.DropDownControl = this.popupBaoCao;
            this.iBaoCao.Id = 15;
            this.iBaoCao.ImageIndex = 3;
            this.iBaoCao.ImageUri.Uri = "DayView";
            this.iBaoCao.LargeImageIndex = 3;
            this.iBaoCao.LargeWidth = 75;
            this.iBaoCao.Name = "iBaoCao";
            // 
            // btnQlyVideo
            // 
            this.btnQlyVideo.Location = new System.Drawing.Point(24, 37);
            this.btnQlyVideo.Name = "btnQlyVideo";
            this.btnQlyVideo.Size = new System.Drawing.Size(102, 23);
            this.btnQlyVideo.TabIndex = 0;
            this.btnQlyVideo.Text = "Quản lý video";
            this.btnQlyVideo.Click += new System.EventHandler(this.btnQlyVideo_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(528, 37);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMatKhau.TabIndex = 1;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.Location = new System.Drawing.Point(282, 37);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(109, 23);
            this.btnQRCode.TabIndex = 3;
            this.btnQRCode.Text = "QRCode";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 362);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnQlyVideo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem iKhachHang;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraBars.PopupMenu popupBaoCao;
        private DevExpress.XtraBars.PopupMenu popupQuanLy;
        private DevExpress.XtraBars.PopupMenu popupLichSu;
        private DevExpress.XtraBars.PopupMenu popupThongKe;
        private DevExpress.XtraBars.BarButtonItem iBaoCao;
        private DevExpress.XtraEditors.SimpleButton btnQlyVideo;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnQRCode;
    }
}
