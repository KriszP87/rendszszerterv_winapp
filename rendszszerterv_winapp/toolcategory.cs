using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendszszerterv_winapp
{
    class toolcategory
    {


        public class Rootobject
        {
            public string status { get; set; }
            public object cause { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string category { get; set; }
            public string maintenanceInterval { get; set; }
            public string description { get; set; }
            public Parentcategory parentCategory { get; set; }
        }

        public class Parentcategory
        {
            public int id { get; set; }
            public string category { get; set; }
            public string maintenanceInterval { get; set; }
            public string description { get; set; }
            public object parentCategory { get; set; }
        }

    }
}
