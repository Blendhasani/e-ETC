using eETC.Data;
using eETC.Data.Services;
/*using eETC.Migrations;*/
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using eETC.Models;
using System;
using eETC.Data.ViewModels;
using eETC.Data.Cart;


namespace eETC.Controllers
{
    public class AdditionalDatasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IAdditionalDatasService _service;
      
        private readonly IOrdersService _orderService;
       
        public AdditionalDatasController(AppDbContext context, IAdditionalDatasService service, IOrdersService orderService)
        {
                _context = context;
            _service = service;
            _orderService = orderService;
        }
      



        [HttpPost]
        public async Task<IActionResult> Perfundimi([Bind("Qyteti,Rruga,NrTel,MenyraPageses")] NewADVM advm)
        {



            await _service.ShtoTeDhenat(advm);




            return View("~/Views/Orders/OrderCompleted.cshtml");



        }

        /*        public async Task<IActionResult> CompleteOrder()
                {
                    var items = _shoppingCart.GetShoppingCartItems();
                    string userId = "";
                    string userEmailAddress = "";
                    DateTime dataPorosise = DateTime.Now;

                    await _service.StoreOrderAsync(items, userId, userEmailAddress, dataPorosise);
                    await _shoppingCart.ClearShoppingCartAsync();
                    return View("OrderCompleted");

                }*/

    }
}
