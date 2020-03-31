using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTBProto.Data.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string price { get; set; }
    }
}
