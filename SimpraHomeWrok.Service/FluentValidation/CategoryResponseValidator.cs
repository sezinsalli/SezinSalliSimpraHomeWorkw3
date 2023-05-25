﻿using FluentValidation;
using SimpraHomework.Shema.CategoryRR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Service.FluentValidation
{
    internal class CategoryResponseValidator : AbstractValidator<CategoryResponse>
    {
        public CategoryResponseValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{Name} is required").NotEmpty().WithMessage("{Name} is required");
        }
    }
}
