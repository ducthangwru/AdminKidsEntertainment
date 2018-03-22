namespace AdminKidsEntertainment
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            this.teUsername = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teEmail = new DevExpress.XtraEditors.TextEdit();
            this.teFullname = new DevExpress.XtraEditors.TextEdit();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.btnTaoTK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUsername
            // 
            this.teUsername.Location = new System.Drawing.Point(114, 34);
            this.teUsername.Name = "teUsername";
            this.teUsername.Size = new System.Drawing.Size(180, 20);
            this.teUsername.TabIndex = 0;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(114, 74);
            this.tePassword.Name = "tePassword";
            this.tePassword.Size = new System.Drawing.Size(180, 20);
            this.tePassword.TabIndex = 1;
            // 
            // teEmail
            // 
            this.teEmail.Location = new System.Drawing.Point(114, 117);
            this.teEmail.Name = "teEmail";
            this.teEmail.Size = new System.Drawing.Size(180, 20);
            this.teEmail.TabIndex = 2;
            // 
            // teFullname
            // 
            this.teFullname.Location = new System.Drawing.Point(114, 155);
            this.teFullname.Name = "teFullname";
            this.teFullname.Size = new System.Drawing.Size(180, 20);
            this.teFullname.TabIndex = 3;
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(114, 191);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(180, 20);
            this.deDate.TabIndex = 4;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Location = new System.Drawing.Point(163, 235);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(75, 23);
            this.btnTaoTK.TabIndex = 5;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Email";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Tên đầy đủ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 194);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ngày sinh";
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 301);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.deDate);
            this.Controls.Add(this.teFullname);
            this.Controls.Add(this.teEmail);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teUsername;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teEmail;
        private DevExpress.XtraEditors.TextEdit teFullname;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.SimpleButton btnTaoTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}