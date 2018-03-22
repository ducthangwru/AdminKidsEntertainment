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
    public partial class FormCreateAccount : DevExpress.XtraEditors.XtraForm
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(teUsername.Text) || string.IsNullOrEmpty(tePassword.Text))
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu là trường bắt buộc", "Tạo tài khoản");
            }
            else
            {
                try
                {
                    Object body = new
                    {
                        username = teUsername.Text,
                        password = tePassword.Text,
                        email = teEmail.Text,
                        avatar = "",
                        tokenfirebase  =  "",
                        fullname = teFullname.Text,
                        dateofbirth  = deDate.Text
                    };

                    var client = new RestClient(Config.BASEURL + "/api/user");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("content-type", "application/json");
                    request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);
                    XtraMessageBox.Show(obj.msg, "Tạo tài khoản");
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại!", "Lỗi");
                }
            }
        }
    }
}