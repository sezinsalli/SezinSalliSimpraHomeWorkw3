using SimpraHomework.Shema.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Shema.ProductRR
{
    public class ProductResponse : BaseResponse
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

    }
}
