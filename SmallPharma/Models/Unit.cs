using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Unit
    {
        public int UnitID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<TradeName> TradeNames { get; set; }
    }
}
