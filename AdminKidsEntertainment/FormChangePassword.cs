using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AdminKidsEntertainment.DataAccess;
using RestSharp;
using Newtonsoft.Json;
using AdminKidsEntertainment.DataAccess.Object;

namespace AdminKidsEntertainment
{
    public partial class FormChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void txbMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoiMatKhau();
        }

        private void txbXacNhanMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoiMatKhau();
        }

        private void txbMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DoiMatKhau();
        }

        private bool CheckOMatKhau()
        {
            if (string.IsNullOrEmpty(txbMatKhauMoi.Text))
            {
                peXacNhanMK.Visible = false;
                return false;
            }
            else if (string.Compare(txbMatKhauMoi.Text, txbXacNhanMK.Text) != 0)
            {
                peXacNhanMK.Visible = true;
                peXacNhanMK.Image = AdminKidsEntertainment.Properties.Resources.cancel_32x32;
                return false;
            }
            else
            {
                peXacNhanMK.Visible = true;
                peXacNhanMK.Image = AdminKidsEntertainment.Properties.Resources.apply_32x32;
                return true;
            }
        }

        private void DoiMatKhau()
        {
            try
            {
                if (string.IsNullOrEmpty(txbMatKhauCu.Text) || string.IsNullOrEmpty(txbMatKhauMoi.Text) || string.IsNullOrEmpty(txbXacNhanMK.Text))
                {
                    MessageBox.Show("Có trường đang trống! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!CheckOMatKhau())
                {
                    MessageBox.Show("Mật khẩu không trùng khớp! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var client = new RestClient(Config.BASEURL + "/api/user/changepassword");
                var request = new RestRequest(Method.POST);
                request.AddHeader("token", Config.TOKEN);
                request.AddHeader("content-type", "application/json");

                Object body = new
                {
                    idlogin = Config.ID_NHANVIEN,
                    username = Config.USERNAME,
                    password = txbMatKhauCu.Text,
                    newpassword = txbMatKhauMoi.Text
                };

                request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);

                XtraMessageBox.Show(obj.msg, "Đổi mật khẩu");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu! Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }

        private void txbMatKhauMoi_EditValueChanged(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }

        private void txbXacNhanMK_EditValueChanged(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }

        private void txbXacNhanMK_EditValueChanged_1(object sender, EventArgs e)
        {
            CheckOMatKhau();
        }
    }
}