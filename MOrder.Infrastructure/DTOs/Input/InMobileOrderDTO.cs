using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Input
{
    public class InMobileOrderDTO
    {
        [Required]
        public int StolId { get; set; }
        [Required]
        public string UserNameProdavaca { get; set; }
        public string DodatniOpis { get; set; }

    }
}
