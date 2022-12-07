using eETC.Data.Enum;
using eETC.Data.ViewModels;
using eETC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eETC.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress,DateTime dataPorosise);


        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
 /*       Task ShtoTeDhenat(NewOrderVM newOrderVM);*/
        int GetOrderIds();
        /*int GetOrderById();*/
        /*int GetOrderId();*/
    }
}
