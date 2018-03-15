using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKidsEntertainment.DataAccess.Object
{
        public class Group
        {
            public string _id { get; set; }
            public string groupname { get; set; }
            public bool isadmin { get; set; }
        }

        public class Data
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string email { get; set; }
            public string avatar { get; set; }
            public object tokenfirebase { get; set; }
            public string fullname { get; set; }
            public string dateofbirth { get; set; }
            public bool status { get; set; }
            public Group group { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
        }

        public class Menu
        {
            public string _id { get; set; }
            public int index { get; set; }
            public string mcode { get; set; }
            public string mname { get; set; }
            public string screen { get; set; }
            public string icon { get; set; }
            public string color { get; set; }
            public bool visiable { get; set; }
        }

        public class LoginOBJ
        {
            public bool status { get; set; }
            public string msg { get; set; }
            public Data data { get; set; }
            public string token { get; set; }
            public List<Menu> menus { get; set; }
        }
}
