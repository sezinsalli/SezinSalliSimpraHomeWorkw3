﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Core.Entity
{
    public class Category:Base
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
