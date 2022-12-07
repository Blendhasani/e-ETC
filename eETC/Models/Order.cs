using eETC.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eETC.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }

        public DateTime dataPorosise { get; set; }
        public List<OrderItem> OrderItems { get; set; }
       /* [Required(ErrorMessage = "Qyteti duhet te plotesohet")]
        [Display(Name = "Qyteti")]*/
   /*     public string Qyteti { get; set; }

        [Required(ErrorMessage = "Rruga duhet te plotesohet")]
        [Display(Name = "Rruga")]
        public string Rruga { get; set; }

        [Required(ErrorMessage = "Numri telefonit duhet te plotesohet")]
        [Display(Name = "NrTel")]
        public string NrTel { get; set; }

        public MenyraPageses MenyraPageses { get; set; }*/

    }
}
