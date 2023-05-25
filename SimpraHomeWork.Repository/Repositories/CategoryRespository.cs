using Microsoft.EntityFrameworkCore;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Core.Repositories;
using SimpraHomeWork.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Category> GetSingleCategoryByIdwithProductAsync(int categoryId)
        {
            return await _appDbContext.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }

    }
}
