using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public enum WorkerType
    {
        Pharmacist,
        Assistant,
        Worker,
        Delivery
    }
    public class Worker
    {
        public int WorkerID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FireDate { get; set; }
        [DataType(DataType.Currency)]
        public float Salary { get; set; }
        public WorkerType WorkerType { get; set; }

        public ICollection<Salary> Salaries { get; set; }
    }
}
