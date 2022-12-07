using eETC.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace eETC.Data.ViewModels
{
    public class NewOrderVM
    {
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Qyteti duhet te plotesohet")]
        [Display(Name = "Qyteti")]
        public string Qyteti { get; set; }

        [Required(ErrorMessage = "Rruga duhet te plotesohet")]
        [Display(Name = "Rruga")]
        public string Rruga { get; set; }

        [Required(ErrorMessage = "Numri telefonit duhet te plotesohet")]
        [Display(Name = "Numri telefonit")]
        public string NrTel { get; set; }
        
        public MenyraPageses MenyraPageses { get; set; }
    }
}
