using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKidsEntertainment.DataAccess.Object
{
    public class DataCategoryOBJ
    {
        public string _id { get; set; }
        public string menu { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
    }

    public class CategoryOBJ
    {
        public bool status { get; set; }
        public string msg { get; set; }
        public List<DataCategoryOBJ> data { get; set; }
    }
}
