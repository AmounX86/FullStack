using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class Salary
    {
        public int SalaryID { get; set; }
        [ForeignKey("Worker")]
        public int WorkerID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public float Amount { get; set; }

        public Worker Worker { get; set; }
    }
}
