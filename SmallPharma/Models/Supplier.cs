using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(15)]
        public string Phone1 { get; set; }
        [MaxLength(15)]
        public string Phone2 { get; set; }
        [MaxLength(15)]
        public string Phone3 { get; set; }
        [MaxLength(15)]
        public string Phone4 { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }

        public virtual ICollection<TradeNameSupp> TradeNameSupps { get; set; }

    }
}
