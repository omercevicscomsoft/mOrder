using MOrder.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.DTOs.Output
{
    public class OutMobileOrder
    {
        public int Id { get; set; }
        public int StolId { get; set; }
        public DateTime DatumIvrijeme { get; set; }
        public string UserNameProdavaca { get; set; }
        public string DodatniOpis { get; set; }
        public Status Status { get; set; }
        public IEnumerable<OutMobileOrderItem> MobileOrderItems { get; set; }
        public bool Fakturisano { get; set; }
    }
}
