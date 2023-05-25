using Microsoft.EntityFrameworkCore;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Core.Repositories;
using SimpraHomeWork.Repository.GenericRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

       
        public async Task<List<Product>> GetProductswithCategoryAsync()
        {
            return await _appDbContext.Products.AsNoTracking().Include(x => x.Category).ToListAsync();
            
        }
        public async Task<List<Product>> GetProductInfoAsync()
        {
            return await _appDbContext.Products.Where(x => x.Name.StartsWith("K") || x.Name.EndsWith("İ") || (x.Name.Contains("C"))).ToListAsync();

        }

        public async Task<List<Product>> GetProductInfo2Async()
        {
            return await _appDbContext.Products.Where(x => x.Price>1000 && x.Stock<400 || x.Stock>1000 && x.Price>1000 ).ToListAsync();
                
        }
    }
}
