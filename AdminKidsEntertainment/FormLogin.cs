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
using RestSharp;
using Newtonsoft.Json;
using AdminKidsEntertainment.DataAccess.Object;
using AdminKidsEntertainment.DataAccess;

namespace AdminKidsEntertainment
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            //string videoUrl = originalUrl.Replace("watch?v=", "v/");﻿
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            try
            {
                if (string.IsNullOrEmpty(teUsername.Text) || string.IsNullOrEmpty(tePassword.Text))
                {
                    XtraMessageBox.Show("Tên tài khoản hoặc mật khẩu đang trống! Vui lòng kiểm tra lại!", "Đăng nhập");
                }
                else
                {
                    var client = new RestClient(Config.BASEURL + "/api/user/login");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("content-type", "application/json");

                    Object body = new
                    {
                        username = teUsername.Text,
                        password = tePassword.Text
                    };

                    request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    LoginOBJ obj = JsonConvert.DeserializeObject<LoginOBJ>(response.Content);

                    //Nếu status = true và là admin thì cho đăng nhập vào
                    if(obj.status && obj.data.group.isadmin)
                    {
                        Config.ID_NHANVIEN = obj.data._id;
                        Config.TOKEN = obj.token;
                        Config.USERNAME = obj.data.username;

                        FormMain frmMain = new FormMain();
                        this.Hide();
                        frmMain.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Đăng nhập");
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!", "Đăng nhập");
            }
        }

        private void teUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void tePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
    }
}