using System.Threading.Tasks;
using CSTC501.UsingDapper.Dtos;
using System.Collections.Generic;

namespace CSTC501.UsingDapper.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync (CreateProductDto cpdto);
        Task UpdateProductAsync (UpdateProductDto updto);
        Task DeleteProductAsync(int id);
        Task GetByProductIdAsync(int id);
    }   
}       
