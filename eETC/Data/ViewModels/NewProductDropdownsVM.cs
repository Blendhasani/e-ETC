using eETC.Models;
using System.Collections.Generic;

namespace eETC.Data.ViewModels
{
    public class NewProductDropdownsVM
    {


        public NewProductDropdownsVM()
        {
            States = new List<State>();
        }


        public List<State> States { get; set; }
    }
}
