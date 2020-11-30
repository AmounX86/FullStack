using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class ClientLedger
    {
        public int ClientLedgerID { get; set; }
        [ForeignKey("Client")]
        public int ClientID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public float Amount { get; set; }

        public Client Client { get; set; }
    }
}
