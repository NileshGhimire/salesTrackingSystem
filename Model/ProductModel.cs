using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ProductModel
    {
        public int Product_ID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Unit { get; set; }
        public int ProductCategory_ID { get; set; }
        public int UnitRate { get; set; }
        public int PackRate { get; set; }
        public int PackSize { get; set; }
    }
}
