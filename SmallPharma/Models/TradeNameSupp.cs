using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class TradeNameSupp
    {
        public int ID { get; set; }
        [ForeignKey("TradeName")]
        public int TradeNameID { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        public TradeName TradeName { get; set; }
        public Supplier Supplier { get; set; }
    }
}
