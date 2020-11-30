using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Concentration
    {
        public int ConcentrationID { get; set; }
        public float Value { get; set; }
        [MaxLength(100)]
        public string Unit { get; set; }
        [MaxLength(250)]
        public string Notes { get; set; }
        public ICollection<TradeName> TradeNames { get; set; }

    }
}
