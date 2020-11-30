using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailID { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }
        [ForeignKey("StoreItem")]
        public int StoreItemID { get; set; }
        [DataType(DataType.Currency)]
        public int Amount { get; set; }
        public float TotalPrice { get; set; }

        public Invoice Invoice { get; set; }
        public StoreItem StoreItem { get; set; }
    }
}
