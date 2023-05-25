using SimpraHomework.Shema.ProductwCategory;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Service.Response;

namespace SimpraHomeWork.Core.Service
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponse<CategorywithProductResponse>> GetSingleCategoryByIdwithProductAsync(int categoryId);
    }
}
