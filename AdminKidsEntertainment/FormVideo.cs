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
using AdminKidsEntertainment.DataAccess;
using AdminKidsEntertainment.DataAccess.Object;
using Newtonsoft.Json;

namespace AdminKidsEntertainment
{
    public partial class FormVideo : DevExpress.XtraEditors.XtraForm
    {
        private string idCategory = "";
        public FormVideo()
        {
            InitializeComponent();
        }

        private void FormVideo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var client = new RestClient(Config.BASEURL + "/api/category?idlogin" + Config.ID_NHANVIEN + "&idmenu=5a71332c734d1d71dd52a78d");
                var request = new RestRequest(Method.GET);
                request.AddHeader("token", Config.TOKEN);
                request.AddHeader("content-type", "application/json");
                IRestResponse response = client.Execute(request);

                CategoryOBJ obj = JsonConvert.DeserializeObject<CategoryOBJ>(response.Content);
                if(obj.data != null && obj.data.Count > 0)
                {
                    DataTable dt = Utils.ConvertListToDataTable(obj.data);
                    gcDanhMuc.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý danh mục");
            }
          
        }

        private void btnXem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormVideoDetail frmVideoDetail = new FormVideoDetail(gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns["_id"]).ToString());
            this.Hide();
            frmVideoDetail.ShowDialog();
            this.Show();
        }

        private void gvDanhMuc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            teAnhDaiDien.Text = gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns["image"]).ToString();
            teMoTa.Text = gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns["description"]).ToString();
            teTenDanhMuc.Text = gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns["name"]).ToString();
            idCategory = gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns["_id"]).ToString();
            peAvatarDanhMuc.LoadAsync(teAnhDaiDien.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(teTenDanhMuc.Text) || string.IsNullOrEmpty(teAnhDaiDien.Text) || string.IsNullOrEmpty(teMoTa.Text))
            {
                XtraMessageBox.Show("Có trường rỗng! Vui lòng điền đủ thông tin!", "Thêm mới");
            }
            else
            {
                try
                {
                    var client = new RestClient(Config.BASEURL + "/api/category");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("token", Config.TOKEN);
                    request.AddHeader("content-type", "application/json");

                    Object body = new
                    {
                        idlogin = Config.ID_NHANVIEN,
                        description = teMoTa.Text,
                        image = teAnhDaiDien.Text,
                        name = teTenDanhMuc.Text
                    };

                    request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);

                    XtraMessageBox.Show(obj.msg, "Thêm mới");

                    if(obj.status)
                        LoadData();
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý danh mục");
                }
            }
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(teTenDanhMuc.Text) || string.IsNullOrEmpty(teAnhDaiDien.Text) || string.IsNullOrEmpty(teMoTa.Text))
            {
                XtraMessageBox.Show("Có trường rỗng! Vui lòng điền đủ thông tin!", "Thêm mới");
            }
            else
            {
                try
                {
                    var client = new RestClient(Config.BASEURL + "/api/category");
                    var request = new RestRequest(Method.PUT);
                    request.AddHeader("token", Config.TOKEN);
                    request.AddHeader("content-type", "application/json");

                    Object body = new
                    {
                        idlogin = Config.ID_NHANVIEN,
                        id = idCategory,
                        description = teMoTa.Text,
                        image = teAnhDaiDien.Text,
                        name = teTenDanhMuc.Text
                    };

                    request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);

                    XtraMessageBox.Show(obj.msg, "Sửa");

                    if (obj.status)
                        LoadData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý danh mục");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    idCategory = gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns["_id"]).ToString();
                    var client = new RestClient(Config.BASEURL + "/api/category?idlogin=" + Config.ID_NHANVIEN + "&id=" + idCategory);
                    var request = new RestRequest(Method.DELETE);
                    request.AddHeader("token", Config.TOKEN);
                    request.AddHeader("content-type", "application/json");
                    IRestResponse response = client.Execute(request);
                    StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);
                    XtraMessageBox.Show(obj.msg, "Xóa");
                    if (obj.status)
                        LoadData();
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý danh mục");
                }
               
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }
    }
}