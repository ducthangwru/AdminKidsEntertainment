namespace AdminKidsEntertainment
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.peAvatarDanhMuc = new DevExpress.XtraEditors.PictureEdit();
            this.teTenDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.teAnhDaiDien = new DevExpress.XtraEditors.TextEdit();
            this.teMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAvatarDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAnhDaiDien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMoTa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMuc
            // 
            this.gcDanhMuc.Location = new System.Drawing.Point(12, 205);
            this.gcDanhMuc.MainView = this.gvDanhMuc;
            this.gcDanhMuc.Name = "gcDanhMuc";
            this.gcDanhMuc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXem,
            this.btnXoa});
            this.gcDanhMuc.Size = new System.Drawing.Size(832, 250);
            this.gcDanhMuc.TabIndex = 0;
            this.gcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvDanhMuc.GridControl = this.gcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDanhMuc_RowClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "_id";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên danh mục";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 185;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ảnh đại diện";
            this.gridColumn2.FieldName = "image";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 215;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mô tả";
            this.gridColumn3.FieldName = "description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 318;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Xem";
            this.gridColumn4.ColumnEdit = this.btnXem;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 96;
            // 
            // btnXem
            // 
            this.btnXem.AutoHeight = false;
            this.btnXem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXem.Name = "btnXem";
            this.btnXem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXem_ButtonClick);
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Xóa";
            this.gridColumn5.ColumnEdit = this.btnXoa;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // peAvatarDanhMuc
            // 
            this.peAvatarDanhMuc.Location = new System.Drawing.Point(634, 12);
            this.peAvatarDanhMuc.Name = "peAvatarDanhMuc";
            this.peAvatarDanhMuc.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAvatarDanhMuc.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peAvatarDanhMuc.Size = new System.Drawing.Size(146, 151);
            this.peAvatarDanhMuc.TabIndex = 1;
            // 
            // teTenDanhMuc
            // 
            this.teTenDanhMuc.Location = new System.Drawing.Point(232, 30);
            this.teTenDanhMuc.Name = "teTenDanhMuc";
            this.teTenDanhMuc.Size = new System.Drawing.Size(213, 20);
            this.teTenDanhMuc.TabIndex = 2;
            // 
            // teAnhDaiDien
            // 
            this.teAnhDaiDien.Location = new System.Drawing.Point(232, 69);
            this.teAnhDaiDien.Name = "teAnhDaiDien";
            this.teAnhDaiDien.Size = new System.Drawing.Size(213, 20);
            this.teAnhDaiDien.TabIndex = 3;
            // 
            // teMoTa
            // 
            this.teMoTa.Location = new System.Drawing.Point(232, 112);
            this.teMoTa.Name = "teMoTa";
            this.teMoTa.Size = new System.Drawing.Size(213, 20);
            this.teMoTa.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(111, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên danh mục";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(111, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ảnh đại diện";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(111, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mô tả";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(679, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ảnh đại diện";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(232, 157);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(370, 157);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDanhMuc.TabIndex = 10;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 467);
            this.Controls.Add(this.btnSuaDanhMuc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teMoTa);
            this.Controls.Add(this.teAnhDaiDien);
            this.Controls.Add(this.teTenDanhMuc);
            this.Controls.Add(this.peAvatarDanhMuc);
            this.Controls.Add(this.gcDanhMuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVideo";
            this.Text = "Quản lý danh mục";
            this.Load += new System.EventHandler(this.FormVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAvatarDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAnhDaiDien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMoTa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXem;
        private DevExpress.XtraEditors.PictureEdit peAvatarDanhMuc;
        private DevExpress.XtraEditors.TextEdit teTenDanhMuc;
        private DevExpress.XtraEditors.TextEdit teAnhDaiDien;
        private DevExpress.XtraEditors.TextEdit teMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSuaDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}