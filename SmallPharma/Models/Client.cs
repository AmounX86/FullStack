using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Client
    {
        public int ClientID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public byte Age { get; set; }
        public Gender Gender { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone1 { get; set; }
        [MaxLength(15)]
        public string Phone2 { get; set; }
        [MaxLength(250)]
        public string Notes { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
