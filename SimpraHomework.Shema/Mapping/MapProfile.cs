using AutoMapper;
using SimpraHomework.Shema.CategoryRR;
using SimpraHomework.Shema.ProductRR;
using SimpraHomework.Shema.ProductwCategory;
using SimpraHomeWork.Core.Entity;


namespace SimpraHomework.Shema.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
           CreateMap<Category,CategoryResponse>();
           CreateMap<CategoryRequest,Category>();


            CreateMap<Product, ProductResponse>();
            CreateMap<ProductRequest, Product>();

            CreateMap<Category, CategorywithProductResponse>();
            CreateMap<Product, ProductwithCategoryResponse>();
            

        }
    }
}
