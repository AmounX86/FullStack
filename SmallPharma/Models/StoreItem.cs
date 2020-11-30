using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace SmallPharma.Models
{
    public class StoreItem
    {
        public int StoreItemID { get; set; }
        [ForeignKey("TradeName")]
        public int TradeNameID { get; set; }
        public int Units { get; set; }
        public string BatchNo { get; set; }
        [DataType(DataType.Date)]
        public DateTime Poduction { get; set; }
        [DataType(DataType.Date)]
        public DateTime Expire { get; set; }

        public TradeName TradeName { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<ClaimDetail> ClaimDetails { get; set; }
    }
}
