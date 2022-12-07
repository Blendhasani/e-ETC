using eETC.Data.Enum;
using eETC.Data.Services;
using eETC.Data.ViewModels;
using eETC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;



namespace eETC.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductsService _service;
    
        public ProductsController(IProductsService service)
        {
            _service = service; 

        }
        public async Task<IActionResult> Index()
        {
            var allProducts = await _service.GetAllAsync();
            return View(allProducts);
        }

       public async Task<IActionResult> Create()
        {
            var productsDropdownData = await _service.GetNewProductDropdownValues();

            ViewBag.States = new SelectList(productsDropdownData.States, "Id", "FactoryName");
            return View();
        }

        //test

  
        [HttpPost]
        public async Task<IActionResult> Create(NewProductVM product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _service.AddNewProductAsync(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreateT()
        {
            var productsDropdownData = await _service.GetNewProductDropdownValues();

            ViewBag.States = new SelectList(productsDropdownData.States, "Id", "FactoryName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateT(NewProductTjeterVM product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _service.AddNewProductTjeterAsync(product);
            return RedirectToAction(nameof(Index));
        }




        public async Task<IActionResult> Delete(int id)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null) return View("NotFound");
            return View(product);
        }

        [HttpPost ,ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            if (productDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit (int id)
        {
            var productDetails = await _service.GetByIdAsync (id);
            if (productDetails == null) return View("NotFound");

            var response = new NewProductVM()
            {
                Id = productDetails.Id,
                ProductName = productDetails.ProductName,
                Description = productDetails.Description,
                Price = productDetails.Price,
                Produced = productDetails.Produced,
                Expiration = productDetails.Expiration,
                ImgUrl = productDetails.ImgUrl,
                ProductCategory = productDetails.ProductCategory,
                StateId = productDetails.StateId,
            };

            var productDropdown = await _service.GetNewProductDropdownValues();
            ViewBag.States = new SelectList(productDropdown.States, "Id", "FactoryName");
            return View(response);
        }


        [HttpPost]

        public async Task<IActionResult> Edit (int id,NewProductVM product)
        {
            if(id != product.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            await _service.UpdateProductAsync(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> FilterL()
        {
          var products = await _service.GetAllAsync();
            ProductCategory p1 = ProductCategory.Lengje;
           
            var filteredResult = products.Where(n => n.ProductCategory.Equals(p1));
            return View("Index",filteredResult);
        }

        public async Task<IActionResult> FilterU()
        {
            var products = await _service.GetAllAsync();
          
            ProductCategory p2 = ProductCategory.Ushqimore;
            var filteredResult = products.Where(n => n.ProductCategory.Equals(p2));
            return View("Index", filteredResult);
        }

        public async Task<IActionResult> FilterP()
        {
            var products = await _service.GetAllAsync();
      
            ProductCategory p3 = ProductCategory.Produkte_Qumeshti;
         
            var filteredResult = products.Where(n => n.ProductCategory.Equals(p3));
            return View("Index", filteredResult);
        }

        public async Task<IActionResult> FilterT()
        {
            var products = await _service.GetAllAsync();

            ProductCategory p4 = ProductCategory.Tjeter;

            var filteredResult = products.Where(n => n.ProductCategory.Equals(p4));
            return View("Tjeter", filteredResult);
        }

        public async Task<IActionResult> Filter (string searchString)
        {
            var products = await _service.GetAllAsync();
            ProductCategory p4 = ProductCategory.Tjeter;
            Product p = new Product();

            
            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResults = products.Where(n => n.ProductName.ToLower().Contains(searchString) || n.Description.ToLower().Contains(searchString)).ToList();
                var f = products.Where(n => n.ProductCategory.Equals(p4) && (n.ProductName.ToLower().Contains(searchString) || n.Description.ToLower().Contains(searchString))).ToList();
                //var d = products.Any(n => n.ProductCategory.Equals(p4) && n.ProductName.ToLower().Contains(searchString) || n.Description.ToLower().Contains(searchString));
               
                if (f.Any())
                {
                    return View("Tjeter", f);
                }
                else
                {
                    return View("Index", filterResults);
                }
                
            }
            return View("Index", products);
        }


        public async Task<IActionResult> Details (int id)
        {
            var productDetails = await _service.GetProductByIdAsync(id);
            return View(productDetails);
        }
    }
}
