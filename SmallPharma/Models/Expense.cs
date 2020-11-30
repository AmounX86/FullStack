using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public float Amount { get; set; }
    }
}
