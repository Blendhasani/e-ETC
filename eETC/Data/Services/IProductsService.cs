using eETC.Data.Base;
using eETC.Data.ViewModels;
using eETC.Models;
using System.Threading.Tasks;

namespace eETC.Data.Services
{
    public interface IProductsService :IEntityBaseRepository<Product>
    {

        Task<Product> GetProductByIdAsync(int id);
        Task<NewProductDropdownsVM> GetNewProductDropdownValues();
        Task AddNewProductAsync(NewProductVM data);
        Task AddNewProductTjeterAsync(NewProductTjeterVM data);

        Task UpdateProductAsync(NewProductVM data);
        
    }
}
