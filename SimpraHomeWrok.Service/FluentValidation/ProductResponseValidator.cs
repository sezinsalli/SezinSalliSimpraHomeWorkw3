﻿using FluentValidation;
using SimpraHomework.Shema.ProductRR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Service.FluentValidation
{
    public class ProductResponseValidator : AbstractValidator<ProductResponse>
    {
        public ProductResponseValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{Name} is required").NotEmpty().WithMessage("{Name} is required");
            RuleFor(x => x.Stock).NotNull().WithMessage("{Stock} is required").NotEmpty().WithMessage("{Stock} is required");
            RuleFor(x => x.Price).NotNull().WithMessage("{Price} is required").NotEmpty().WithMessage("{Price} is required");
            
        }
    }
}
