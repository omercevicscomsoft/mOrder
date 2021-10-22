using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Input
{
    public class InMobileOrderDTO
    {
        public int Id { get; set; }
        [Required]
        public int StolId { get; set; }
        [Required]
        public string UserNameProdavaca { get; set; }
        [Required]
        public List<InMobileOrderItemDTO> OrderItems { get; set; }
        public string DodatniOpis { get; set; }

    }
}
