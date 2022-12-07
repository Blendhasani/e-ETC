using eETC.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eETC.Models
{
    public class State:IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Shteti duhet te plotesohet")]
        [Display(Name ="Shteti")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Fabrika duhet te plotesohet")]
        [Display(Name = "Fabrika")]
        public string FactoryName { get; set; }
		
	}
}
