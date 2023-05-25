using FluentValidation;
using SimpraHomework.Shema.CategoryRR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Service.FluentValidation
{
    public class CategoryRequestValidator : AbstractValidator<CategoryRequest>
    {
        public CategoryRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{Name} is required").NotEmpty().WithMessage("{Name} is required");
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("{Id} must be greater than 0");
        }
    }
}
