using eETC.Data.Base;
using eETC.Data.ViewModels;
using eETC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eETC.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {

        public ProductsService(AppDbContext context) : base(context)
        {

        }


        public async Task AddNewProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                ProductName = data.ProductName,
                Description = data.Description,
                Price = data.Price,
                Produced = data.Produced,
                Expiration = data.Expiration,
                ImgUrl = data.ImgUrl,
                ProductCategory = data.ProductCategory,
                StateId = data.StateId
            };

            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();



        }

      
        public async Task UpdateProductAsync(NewProductVM data)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == data.Id);

            if (product != null)
            {
                product.ProductName = data.ProductName;
                product.Description = data.Description;
                product.Price = data.Price;
                product.Produced = data.Produced;
                product.Expiration = data.Expiration;
                product.ImgUrl = data.ImgUrl;
                product.ProductCategory = data.ProductCategory;
                product.StateId = data.StateId;

                
            }

            await _context.SaveChangesAsync();


        }

        
        public async Task<NewProductDropdownsVM> GetNewProductDropdownValues()
        {
            var response = new NewProductDropdownsVM()
            {

                States = await _context.States.OrderBy(n => n.FactoryName).ToListAsync()

        };
            return response;
        }

    public async Task<Product> GetProductByIdAsync(int id)
        {
            var products = await _context.Products
                .Include(s => s.State)
                .FirstOrDefaultAsync(n=>n.Id == id);

            return products;
            
        }

        //test
        public async Task AddNewProductTjeterAsync(NewProductTjeterVM data)
        {
            var newProduct = new Product()
            {
                ProductName = data.ProductName,
                Description = data.Description,
                Price = data.Price,
                ImgUrl = data.ImgUrl,
                ProductCategory = data.ProductCategory,
                StateId = data.StateId
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
        }
    }
}
