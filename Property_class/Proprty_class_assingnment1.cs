using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_class
{
    public class product
    {
        private string name;
        private int code, price;

      public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Code
        {
            set { code = value; }
            get { return code; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Printprduct()
        {
            return $"product name is {name} code is {code} price is {price}";
        }
    }
}
