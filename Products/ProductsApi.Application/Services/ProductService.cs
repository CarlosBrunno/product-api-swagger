using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsApi.Domain.Entities;
using ProductsApi.Domain.Interfaces;

namespace ProductsApi.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<Product>> GetAllAsync() => _productRepository.GetAllAsync();
        public Task<Product> GetByIdAsync(Guid id) => _productRepository.GetByIdAsync(id);
        public Task AddAsync(Product product) => _productRepository.AddAsync(product);
        public Task UpdateAsync(Product product) => _productRepository.UpdateAsync(product);
        public Task DeleteAsync(Guid id) => _productRepository.DeleteAsync(id);
    }
}
