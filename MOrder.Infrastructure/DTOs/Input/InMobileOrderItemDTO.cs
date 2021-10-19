using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Input
{
    public class InMobileOrderItemDTO
    {
        [Required]
        public int MobileOrderId { get; set; }

        [Required]
        public string SifraArtikla { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public decimal Kolicina { get; set; }
        public string SifraGrupeArtikala { get; set; }
    }
}
