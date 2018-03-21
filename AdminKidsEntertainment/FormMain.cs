using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;

namespace AdminKidsEntertainment
{
    public partial class FormMain : XtraForm
    {
        public FormMain()
        {
            InitializeComponent();

        }

        private void btnQlyVideo_Click(object sender, EventArgs e)
        {
            FormVideo frmVideo = new FormVideo();
            this.Hide();
            frmVideo.ShowDialog();
            this.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            FormQRCode frm = new FormQRCode();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}