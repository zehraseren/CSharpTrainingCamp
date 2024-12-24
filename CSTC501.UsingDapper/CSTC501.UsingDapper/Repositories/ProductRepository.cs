using System;
using System.Threading.Tasks;
using CSTC501.UsingDapper.Dtos;
using System.Collections.Generic;

namespace CSTC501.UsingDapper.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProductAsync(CreateProductDto cpdto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByProductIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updto)
        {
            throw new NotImplementedException();
        }
    }
}
