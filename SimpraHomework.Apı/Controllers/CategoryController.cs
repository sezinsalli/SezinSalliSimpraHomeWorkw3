using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpraHomework.Shema.CategoryRR;
using SimpraHomework.Shema.NoContent;
using SimpraHomework.Shema.ProductRR;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Core.Service;
using SimpraHomeWork.Service.Response;

namespace SimpraHomework.Apı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Category> _service;
        private readonly ICategoryService _categoryService;

        public CategoryController(IMapper mapper, IService<Category> service, ICategoryService categoryService)
        {
            _service = service;
            _mapper = mapper;
            _categoryService = categoryService;

        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdwithProducts(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByIdwithProductAsync(categoryId));
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var categories = await _service.GetAllAsync();
            var categoryResponse = _mapper.Map<List<CategoryResponse>>(categories.ToList());

            return Ok(CustomResponse<List<CategoryResponse>>.Success(200, categoryResponse));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categories = await _service.GetByIdAsync(id);

            if (categories == null)
            {
                return CreateActionResult(CustomResponse<List<CategoryResponse>>.Fail(400, "Bu id'ye sahip ürün bulunmamaktadır."));
            }

            var categoriesResponse = _mapper.Map<CategoryResponse>(categories);
            return CreateActionResult(CustomResponse<CategoryResponse>.Success(200, categoriesResponse));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryRequest categoryRequest)
        {
            var category = await _service.AddAsync(_mapper.Map<Category>(categoryRequest));
            var categoryRequests = _mapper.Map<List<CategoryRequest>>(category);
            return CreateActionResult(CustomResponse<List<CategoryRequest>>.Success(201, categoryRequests));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryResponse categoryResponse)
        {
            await _service.UpdateAsync(_mapper.Map<Category>(categoryResponse));

            return CreateActionResult(CustomResponse<List<NoContent>>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var category = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(category);
            return CreateActionResult(CustomResponse<NoContent>.Success(204));
        }
    }
}
