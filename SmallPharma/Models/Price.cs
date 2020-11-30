using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Price
    {
        public int PriceID { get; set; }
        [ForeignKey("TradeName")]
        public int TradeNameID { get; set; }
        [DataType(DataType.Currency)]
        public float Value { get; set; }
        public TradeName TradeName { get; set; }

    }
}
