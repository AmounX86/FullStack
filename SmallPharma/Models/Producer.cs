using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Producer
    {
        public int ProducerID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(250)]
        public string Notes { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        public ICollection<TradeName> TradeNames { get; set; }
    }
}
