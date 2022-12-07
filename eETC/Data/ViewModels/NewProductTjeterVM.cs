using eETC.Data.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace eETC.Data.ViewModels
{
    public class NewProductTjeterVM
    {

        public int Id { get; set; }


        [Display(Name = "Emri produktit")]
        [Required(ErrorMessage = "Emri duhet te plotesohet")]
        public string ProductName { get; set; }


        [Display(Name = "Fotografia e produktit")]
        [Required(ErrorMessage = "Fotografia duhet te plotesohet")]
        public string ImgUrl { get; set; }


        [Display(Name = "Pershkrimi i produktit")]
        [Required(ErrorMessage = "Pershkrimi duhet te plotesohet")]
        public string Description { get; set; }


        [Display(Name = "Cmimi i produktit")]
        [Required(ErrorMessage = "Cmimi duhet te plotesohet")]
        public double Price { get; set; }


        [Display(Name = "Zgjedh nje kategori")]
        [Required(ErrorMessage = "Kategoria duhet te plotesohet")]
        public ProductCategory ProductCategory { get; set; }


        [Display(Name = "Zgjedh nje fabrike")]
        [Required(ErrorMessage = "Fabrike duhet te plotesohet")]
        public int StateId { get; set; }


        public static DateTime Produced = new DateTime(2020, 1, 1);


        public static DateTime Expiration = new DateTime(2030, 1, 1);


    }
}
