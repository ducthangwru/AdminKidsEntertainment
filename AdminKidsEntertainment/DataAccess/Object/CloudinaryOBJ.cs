using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;

namespace AdminKidsEntertainment.DataAccess.Object
{
    public class CloudinaryOBJ
    {
        public static Cloudinary cloudinary = new Cloudinary(
          new Account(
            "ducthangwru",
            "581286618712862",
            "VxHXdcMzuF0KiNnSy4dRSrQqRQA"));
    }
}
