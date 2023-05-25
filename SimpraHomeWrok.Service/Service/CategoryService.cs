using AutoMapper;
using SimpraHomework.Shema.ProductwCategory;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Core.Repositories;
using SimpraHomeWork.Core.Service;
using SimpraHomeWork.Core.UnitOfWork;
using SimpraHomeWork.Service.Response;


namespace SimpraHomeWork.Service.Service
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitofWork unitofWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitofWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<CustomResponse<CategorywithProductResponse>> GetSingleCategoryByIdwithProductAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdwithProductAsync(categoryId);
            var categoryDto = _mapper.Map<CategorywithProductResponse>(category);
            return CustomResponse<CategorywithProductResponse>.Success(200, categoryDto);
        }
    }
}
