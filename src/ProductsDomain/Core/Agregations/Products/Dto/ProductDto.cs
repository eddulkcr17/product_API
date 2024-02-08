using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsDomain.Core.Agregations.Products.Dto
{
    internal class ProductDto
    {
        public int UPC { get; set; }
        public string productNmae { get; set; }
        public string mfgr { get; set; }
        public string model { get; set; }
        public double unitListPrice { get; set; }
        public int unitInStock { get; set; }
    }
}
