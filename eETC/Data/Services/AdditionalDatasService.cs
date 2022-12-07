using eETC.Data.ViewModels;
using eETC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eETC.Data.Services
{
    public class AdditionalDatasService : IAdditionalDatasService
    {
        private readonly AppDbContext _context;
        private readonly IOrdersService _service;

       
        

        public AdditionalDatasService(AppDbContext context,IOrdersService service)
        {
            _context = context;
            _service = service;
        
        }

        /*public  async Task AddData(NewADVM data)
        {
            var id = _service.GetOrderIds().Id;
            var newAD = new AdditionalData()
            {
                OrderId = id,
                Qyteti = data.Qyteti,
                Rruga = data.Rruga,
                NrTel = data.NrTel,
             
            };

            await _context.AdditionalDatas.AddAsync(newAD);
            await _context.SaveChangesAsync();

        }*/


        public async Task ShtoTeDhenat(NewADVM newADVM)
        {
            
           
            
            var newAD = new AdditionalData()
            {
                OrderId = newADVM.OrderId,
                Qyteti = newADVM.Qyteti,
                Rruga = newADVM.Rruga,
                NrTel = newADVM.NrTel,
              
             
               
            };
            await _context.AdditionalDatas.AddAsync(newAD);
            await _context.SaveChangesAsync();

        }


        
        
      

       




    }
}
