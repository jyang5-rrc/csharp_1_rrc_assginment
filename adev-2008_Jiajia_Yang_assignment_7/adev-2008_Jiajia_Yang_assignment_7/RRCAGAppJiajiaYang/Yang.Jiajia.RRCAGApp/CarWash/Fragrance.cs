using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yang.Jiajia.RRCAGApp
{
    
    public class Fragrance
    {
        public string name;
        public decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Fragrance()
        {
            this.name = "Pine";
            this.price = 0;
        }

        public Fragrance(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
