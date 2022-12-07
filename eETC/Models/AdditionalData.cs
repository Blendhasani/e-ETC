using eETC.Data.Base;
using eETC.Data.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eETC.Models
{
    public class AdditionalData : IEntityBase
    {
        [Key]
        public int Id { get; set; }

  

        public string Qyteti { get; set; }

        public string Rruga { get; set; }

        public string NrTel { get; set; }


        public MenyraPageses MenyraPageses { get; set; }
        //relationship
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }


    }
}
