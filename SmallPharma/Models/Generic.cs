using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SmallPharma.Models
{
    public class Generic
    {
        public int GenericID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public ICollection<TradeName> TradeNames { get; set; }

    }
}
