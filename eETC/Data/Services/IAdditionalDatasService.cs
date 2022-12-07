using eETC.Data.Base;
using eETC.Data.ViewModels;
using eETC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eETC.Data.Services
{
    public interface IAdditionalDatasService 
    {
        /*Task StoreDataAsync(int orderId,bool Transporti, bool Cash, string Qyteti, string Rruga, string NrTel, DateTime KohaArritjes);*/

       

    /*    Task AddData(AdditionalData data);*/
    Task ShtoTeDhenat(NewADVM newADVM);
      
    }
}
