using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Form
    {
        public int FormID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<TradeName> TradeNames { get; set; }
    }
}
