using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public float Amount { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public bool Paid { get; set; }

        public Supplier Supplier { get; set; }
    }
}
