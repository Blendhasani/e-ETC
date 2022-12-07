using eETC.Data.Enum;
using eETC.Data.ViewModels;
using eETC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eETC.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly AppDbContext _context;

        public OrdersService(AppDbContext context)
        {
               _context = context;
        }

        public int GetOrderIds()
        {
            var id = _context.Orders.Select(o => o.Id).Single();
            return id;
        }

        /* public int GetOrderById()
         {



             var result = _context.Orders.Select(n => n.Id).ToList();




             return result;
         }*/

        /*     public int GetOrderId()
             {

                 var order = _context.Orders
             }*/

        public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Product).Where(n => n.UserId == userId).ToListAsync();


            return orders;
        }




        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress , DateTime dataPorosise)
        {
            Order o = new Order();
        
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress,
                dataPorosise = dataPorosise,
               
              
                
                


            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

             
            foreach(var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    ProductId = item.Product.Id,
                    OrderId = order.Id,
                    Price = item.Product.Price
                     
                };
                await _context.OrderItems.AddAsync(orderItem);
                await _context.SaveChangesAsync();
            }


        }
    }
}
