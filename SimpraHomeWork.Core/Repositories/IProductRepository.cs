using SimpraHomeWork.Core.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductswithCategoryAsync();
        Task<List<Product>> GetProductInfoAsync();
        Task<List<Product>> GetProductInfo2Async();

    }
}
