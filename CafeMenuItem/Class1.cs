using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenuItem
{
    public enum _Category
    {
        Food,
        Beverage,
        Other
    };
    public class CMI
    {
        protected _Category category;
        public string Name { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    _price = 0;
                else
                    _price = value;
            }
        }
        public _Category cate
        {
            get { return category; }
            set { category = value; }
        }

        public CMI( string n, decimal p, _Category c)
        {
          
            Name = n;
            Price = p;
            category = c;
        }
        public override string ToString()
        {
            return $"{Name} - {Price.ToString("C")}";

        }
    }
}
