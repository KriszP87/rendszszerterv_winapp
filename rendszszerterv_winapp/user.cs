using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace rendszszerterv_winapp
{
    class user
    {
        private static Rootobject _userlist;

        public static Rootobject userlist
        {
            get { return _userlist; }
            set
            {
                _userlist = value;
            }
        }
        public class Rootobject
        {
            public string status { get; set; }
            public object cause { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string username { get; set; }
            public string userType { get; set; }
            public Education[] educations { get; set; }
        }

        public class Education
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

    }
}
