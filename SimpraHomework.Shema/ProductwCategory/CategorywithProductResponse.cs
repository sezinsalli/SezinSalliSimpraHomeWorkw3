﻿using SimpraHomework.Shema.CategoryRR;
using SimpraHomework.Shema.ProductRR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Shema.ProductwCategory
{
    public class CategorywithProductResponse:CategoryResponse
    {
        public List<ProductResponse> Products { get; set; }
    }
}
