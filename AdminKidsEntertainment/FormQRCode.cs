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
using System.Drawing.Drawing2D;
using ZXing;
using Newtonsoft.Json;
using ZXing.Common;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using AdminKidsEntertainment.DataAccess.Object;

namespace AdminKidsEntertainment
{
    public partial class FormQRCode : DevExpress.XtraEditors.XtraForm
    {
        private Bitmap qr;
        private Image Frame;
        private int width = 50;
        private int height = 50;

        public FormQRCode()
        {
            InitializeComponent();
        }

        private void teURL_EditValueChanged(object sender, EventArgs e)
        {
            if(teURL.Text.Contains("http"))
            {
                peAnhURL.LoadAsync(teURL.Text);
            }
            else
            {
                try
                {
                    peAnhURL.Image = new Bitmap(teURL.Text);
                }
                catch(Exception ex)
                {
                   
                }
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (dialogUploadFile.ShowDialog() == DialogResult.OK)
            {
                peAnhURL.Image = new Bitmap(dialogUploadFile.FileName);
                teURL.Text = dialogUploadFile.FileName;
            }
        }

        private void btnImageText_Click(object sender, EventArgs e)
        {
            try
            {
                //Nếu là ảnh trên mạng thì vẽ luôn QRCode lên ảnh đó luôn.
                if (teURL.Text.Contains("http") || teURL.Text.Contains("base64"))
                {
                    Object obj = new
                    {
                        url = teURL.Text,
                        text = meMoTa.Text
                    };

                    IBarcodeWriter writer = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new ZXing.Common.EncodingOptions
                        {
                            Height = 300,
                            Width = 300
                        }
                    };
                    var result = writer.Write(JsonConvert.SerializeObject(obj));
                    peQR.Image = result;
                }
                //Nếu là ảnh trên máy thì upload lên để lấy url.
                else
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(teURL.Text)
                    };

                    var uploadResult = CloudinaryOBJ.cloudinary.Upload(uploadParams);

                    Object obj = new
                    {
                        url = uploadResult.Uri.PathAndQuery,
                        text = meMoTa.Text
                    };

                    IBarcodeWriter writer = new BarcodeWriter
                    {
                        Format = BarcodeFormat.QR_CODE,
                        Options = new ZXing.Common.EncodingOptions
                        {
                            Height = 300,
                            Width = 300
                        }
                    };
                    var result = writer.Write(JsonConvert.SerializeObject(obj));
                    peQR.Image = result;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnQRText_Click(object sender, EventArgs e)
        {
            IBarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 300,
                    Width = 300
                }
            };

            var result = writer.Write(meMoTa.Text);
            peQR.Image = result;
        }
    }
}