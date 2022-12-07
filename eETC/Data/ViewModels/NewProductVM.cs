using eETC.Data.Enum;
using eETC.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace eETC.Data.ViewModels
{
    public class NewProductVM
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


        [Display(Name = "Prodhuar")]
        [Required(ErrorMessage = "Data e prodhimit duhet te plotesohet")]
        public DateTime Produced { get; set; }


        [Display(Name = "Skadon")]
        [Required(ErrorMessage = "Data e skadimit duhet te plotesohet")]
        public DateTime Expiration { get; set; }

    

    }
}
