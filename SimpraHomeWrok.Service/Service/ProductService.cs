using AutoMapper;
using SimpraHomework.Shema.ProductRR;
using SimpraHomework.Shema.ProductwCategory;
using SimpraHomeWork.Core.Entity;
using SimpraHomeWork.Core.Repositories;
using SimpraHomeWork.Core.Service;
using SimpraHomeWork.Core.UnitOfWork;
using SimpraHomeWork.Repository.Repositories;
using SimpraHomeWork.Service.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Service.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IUnitofWork unitofWork, IMapper mapper, IProductRepository productRepositor) : base(repository, unitofWork)
        {
            _mapper = mapper;
            _productRepository = productRepositor;

        }

       

        public async Task<CustomResponse<List<ProductwithCategoryResponse>>> GetProductsWithCategoryAsync()
        {
            var products = await _productRepository.GetProductswithCategoryAsync();

            var productsDto = _mapper.Map<List<ProductwithCategoryResponse>>(products);

            return CustomResponse<List<ProductwithCategoryResponse>>.Success(200, productsDto);
        }


        public async Task<CustomResponse<List<ProductResponse>>> GetProductsInfoAsync()
        {
            var products = await _productRepository.GetProductInfoAsync();
            var productsDto = _mapper.Map<List<ProductResponse>>(products);

            return CustomResponse<List<ProductResponse>>.Success(200, productsDto);
        }

        public async Task<CustomResponse<List<ProductResponse>>> GetProductsInfo2Async()
        {
            var products = await _productRepository.GetProductInfo2Async();
            var productsDto = _mapper.Map<List<ProductResponse>>(products);

            return CustomResponse<List<ProductResponse>>.Success(200, productsDto);
        }


    }
}
