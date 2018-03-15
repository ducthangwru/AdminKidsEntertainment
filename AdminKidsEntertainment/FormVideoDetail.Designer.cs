namespace AdminKidsEntertainment
{
    partial class FormVideoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoDetail));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnXem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSuaDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teMoTa = new DevExpress.XtraEditors.TextEdit();
            this.teLinkVideo = new DevExpress.XtraEditors.TextEdit();
            this.teTenVideo = new DevExpress.XtraEditors.TextEdit();
            this.gvVideo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVideo = new DevExpress.XtraGrid.GridControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.flashVideo = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLinkVideo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenVideo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.AutoHeight = false;
            this.btnXem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXem.Name = "btnXem";
            this.btnXem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(370, 183);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDanhMuc.TabIndex = 21;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(678, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Ảnh đại diện";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(111, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Mô tả";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(111, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Link Video";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(111, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tên Video";
            // 
            // teMoTa
            // 
            this.teMoTa.Location = new System.Drawing.Point(232, 138);
            this.teMoTa.Name = "teMoTa";
            this.teMoTa.Size = new System.Drawing.Size(213, 20);
            this.teMoTa.TabIndex = 15;
            // 
            // teLinkVideo
            // 
            this.teLinkVideo.Location = new System.Drawing.Point(232, 95);
            this.teLinkVideo.Name = "teLinkVideo";
            this.teLinkVideo.Size = new System.Drawing.Size(213, 20);
            this.teLinkVideo.TabIndex = 14;
            // 
            // teTenVideo
            // 
            this.teTenVideo.Location = new System.Drawing.Point(232, 56);
            this.teTenVideo.Name = "teTenVideo";
            this.teTenVideo.Size = new System.Drawing.Size(213, 20);
            this.teTenVideo.TabIndex = 13;
            // 
            // gvVideo
            // 
            this.gvVideo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvVideo.GridControl = this.gcVideo;
            this.gvVideo.Name = "gvVideo";
            this.gvVideo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvVideo_RowClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "_id";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên video";
            this.gridColumn1.FieldName = "namevideo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 185;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Link video";
            this.gridColumn2.FieldName = "link";
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Xóa";
            this.gridColumn5.ColumnEdit = this.btnXoa;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gcVideo
            // 
            this.gcVideo.Location = new System.Drawing.Point(12, 231);
            this.gcVideo.MainView = this.gvVideo;
            this.gcVideo.Name = "gcVideo";
            this.gcVideo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXem,
            this.btnXoa});
            this.gcVideo.Size = new System.Drawing.Size(832, 250);
            this.gcVideo.TabIndex = 11;
            this.gcVideo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVideo});
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(232, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // flashVideo
            // 
            this.flashVideo.Enabled = true;
            this.flashVideo.Location = new System.Drawing.Point(609, 12);
            this.flashVideo.Name = "flashVideo";
            this.flashVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashVideo.OcxState")));
            this.flashVideo.Size = new System.Drawing.Size(192, 192);
            this.flashVideo.TabIndex = 22;
            // 
            // FormVideoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 493);
            this.Controls.Add(this.flashVideo);
            this.Controls.Add(this.btnSuaDanhMuc);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teMoTa);
            this.Controls.Add(this.teLinkVideo);
            this.Controls.Add(this.teTenVideo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gcVideo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVideoDetail";
            this.Text = "FormVideoDetail";
            this.Load += new System.EventHandler(this.FormVideoDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnXem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLinkVideo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenVideo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSuaDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teMoTa;
        private DevExpress.XtraEditors.TextEdit teLinkVideo;
        private DevExpress.XtraEditors.TextEdit teTenVideo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVideo;
        private DevExpress.XtraGrid.GridControl gcVideo;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private AxShockwaveFlashObjects.AxShockwaveFlash flashVideo;
    }
}