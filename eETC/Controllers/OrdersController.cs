using eETC.Data.Cart;
using eETC.Data.Enum;
using eETC.Data.Services;
using eETC.Data.ViewModels;
using eETC.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa;
using System;
using System.Threading.Tasks;

namespace eETC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IProductsService _productService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _service;

        public OrdersController(IProductsService productService,ShoppingCart shoppingCart, IOrdersService service)
        {
            _productService = productService;
            _shoppingCart = shoppingCart;
            _service = service;
        }



        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await _service.GetOrdersByUserIdAsync(userId);
            return View(orders);

        }
        

        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);

        }


        public async Task<RedirectToActionResult> AddToShoppingCart(int id)
        {
            
            var item = await _productService.GetProductByIdAsync(id);
            if(item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<RedirectToActionResult> RemoveFromShoppingCart(int id)
        {

            var item = await _productService.GetProductByIdAsync(id);
            if (item != null)
            {
                _shoppingCart.RemoveItemFromShoppingCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }


        /*   public async Task<IActionResult> CompleteOrder()
           {
               var items = _shoppingCart.GetShoppingCartItems();
               string userId = "";
               string userEmailAddress = "";
               DateTime dataPorosise =  DateTime.Now;

               await _service.StoreOrderAsync(items, userId, userEmailAddress, dataPorosise);
               await _shoppingCart.ClearShoppingCartAsync();
               return View("Data");

           }*/
    /*    public IActionResult Send ()
        {
          
                return View("~/Views/AdditionalDatas/TeDhenat.cshtml");
        }*/

        public async Task<IActionResult> CompleteOrder()
        {
            Order o = new Order();
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmailAddress = "";
            DateTime dataPorosise = DateTime.Now;
       
            
       

            await _service.StoreOrderAsync(items, userId, userEmailAddress, dataPorosise);
            await _shoppingCart.ClearShoppingCartAsync();

     
            return View("~/Views/AdditionalDatas/TeDhenat.cshtml");

        }


    }
}
