using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Ebuy.Website.Models
{
    public class Auction
    {
        public Auction()
        {
        }

        public long Id { get; set;}

        [Required]
        [StringLength(50,ErrorMessage ="El titulo no puede ser mas largo de 50 caracteres")]
        public string Title { get; set;}

        [Required]
        public string Description { get; set; }

        [Range(1,10000,ErrorMessage = "La puja inicial deber ser al menos 1€")]
        public decimal StartPrice { get; set; }

        public decimal CurrentPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
     }

   
}