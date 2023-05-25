using SimpraHomework.Shema.ProductRR;
using SimpraHomework.Shema.ProductwCategory;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Core.Service
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponse<List<ProductwithCategoryResponse>>> GetProductsWithCategoryAsync();
        Task<CustomResponse<List<ProductResponse>>> GetProductsInfoAsync();
        Task<CustomResponse<List<ProductResponse>>> GetProductsInfo2Async();

    }
}
