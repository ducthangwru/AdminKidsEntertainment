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
    public partial class FormVideoDetail : DevExpress.XtraEditors.XtraForm
    {
        private string idCategory = "";
        private string idCategoryDetail = "";
        public FormVideoDetail(string idCategory)
        {
            InitializeComponent();
            this.idCategory = idCategory;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void gvVideo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            teLinkVideo.Text = gvVideo.GetRowCellValue(gvVideo.FocusedRowHandle, gvVideo.Columns["link"]).ToString();
            teMoTa.Text = gvVideo.GetRowCellValue(gvVideo.FocusedRowHandle, gvVideo.Columns["description"]).ToString();
            teTenVideo.Text = gvVideo.GetRowCellValue(gvVideo.FocusedRowHandle, gvVideo.Columns["namevideo"]).ToString();
            idCategoryDetail = gvVideo.GetRowCellValue(gvVideo.FocusedRowHandle, gvVideo.Columns["_id"]).ToString();

            flashVideo.Movie = teLinkVideo.Text.Replace("watch?v=", "v/");﻿
        }

        private void LoadData()
        {
            try
            {
                var client = new RestClient(Config.BASEURL + "/api/categoryDetail?idlogin" + Config.ID_NHANVIEN + "&idcategory=" + idCategory);
                var request = new RestRequest(Method.GET);
                request.AddHeader("token", Config.TOKEN);
                request.AddHeader("content-type", "application/json");
                IRestResponse response = client.Execute(request);

                CategoryDetailOBJ obj = JsonConvert.DeserializeObject<CategoryDetailOBJ>(response.Content);
                if (obj.data != null && obj.data.Count > 0)
                {
                    DataTable dt = Utils.ConvertListToDataTable(obj.data);
                    foreach(DataRow dr in dt.Rows)
                    {
                        dr["link"] = "https://www.youtube.com/watch?v=" + dr["link"].ToString();
                    }

                    gcVideo.DataSource = dt;
                }
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý Video");
            }
        }

        private void FormVideoDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teTenVideo.Text) || string.IsNullOrEmpty(teLinkVideo.Text) || string.IsNullOrEmpty(teMoTa.Text))
            {
                XtraMessageBox.Show("Có trường rỗng! Vui lòng điền đủ thông tin!", "Thêm mới");
            }
            else
            {
                try
                {
                    var client = new RestClient(Config.BASEURL + "/api/categoryDetail");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("token", Config.TOKEN);
                    request.AddHeader("content-type", "application/json");

                    string[] result = teLinkVideo.Text.Split('=');

                    Object body = new
                    {
                        idlogin = Config.ID_NHANVIEN,
                        category = idCategory,
                        description = teMoTa.Text,
                        link = result[1],
                        namevideo = teTenVideo.Text
                    };

                    request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);

                    XtraMessageBox.Show(obj.msg, "Thêm mới");

                    if (obj.status)
                        LoadData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý video");
                }
            }
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teTenVideo.Text) || string.IsNullOrEmpty(teLinkVideo.Text) || string.IsNullOrEmpty(teMoTa.Text))
            {
                XtraMessageBox.Show("Có trường rỗng! Vui lòng điền đủ thông tin!", "Thêm mới");
            }
            else
            {
                try
                {
                    var client = new RestClient(Config.BASEURL + "/api/categoryDetail");
                    var request = new RestRequest(Method.PUT);
                    request.AddHeader("token", Config.TOKEN);
                    request.AddHeader("content-type", "application/json");

                    string[] result = teLinkVideo.Text.Split('=');

                    Object body = new
                    {
                        idlogin = Config.ID_NHANVIEN,
                        category = idCategory,
                        id = idCategoryDetail,
                        description = teMoTa.Text,
                        link = result[1],
                        namevideo = teTenVideo.Text
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
                    XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý video");
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    idCategoryDetail = gvVideo.GetRowCellValue(gvVideo.FocusedRowHandle, gvVideo.Columns["_id"]).ToString();
                    var client = new RestClient(Config.BASEURL + "/api/categoryDetail?idlogin=" + Config.ID_NHANVIEN + "&id=" + idCategoryDetail);
                    var request = new RestRequest(Method.DELETE);
                    request.AddHeader("token", Config.TOKEN);
                    request.AddHeader("content-type", "application/json");
                    IRestResponse response = client.Execute(request);
                    StatusOBJ obj = JsonConvert.DeserializeObject<StatusOBJ>(response.Content);
                    XtraMessageBox.Show(obj.msg, "Xóa");
                    if (obj.status)
                        LoadData();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Có lỗi xảy ra Vui lòng kiểm tra lại!", "Quản lý danh mục");
                }

            }
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            string link = gvVideo.GetRowCellValue(gvVideo.FocusedRowHandle, gvVideo.Columns["link"]).ToString();

            System.Diagnostics.Process.Start(link);
        }
    }
}