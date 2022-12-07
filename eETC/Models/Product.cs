using eETC.Data.Base;
using eETC.Data.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace eETC.Models
{
    public class Product : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }

        public string ImgUrl { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime Produced { get; set; }

        public DateTime Expiration { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public State State { get; set; }
        
    }
}
