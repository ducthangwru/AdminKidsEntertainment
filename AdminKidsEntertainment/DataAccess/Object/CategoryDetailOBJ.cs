using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKidsEntertainment.DataAccess.Object
{
    public class DetailsOBJ
    {
        public string _id { get; set; }
        public string namevideo { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string link { get; set; }
    }

    public class CategoryDetailOBJ
    {
        public bool status { get; set; }
        public string msg { get; set; }
        public List<DetailsOBJ> data { get; set; }
    }
}
