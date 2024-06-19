using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates
{
  public  enum CategoriesProduct
    {
        Food,
        Appliances
    }

    internal class Product
    {
       public string PruductName { get; set; }
       public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public CategoriesProduct Category { get; set; }
    }
}
