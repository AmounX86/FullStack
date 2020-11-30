using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmallPharma.Models
{
    public class TradeName
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Barcode { get; set; }
        [ForeignKey("Generic")]
        public int GenericID { get; set; }
        [ForeignKey("Producer")]
        public int ProducerID { get; set; }
        [ForeignKey("Form")]
        public int FormID { get; set; }
        [ForeignKey("Concentration")]
        public int ConcentrationID { get; set; }
        [ForeignKey("Price")]
        public int PriceID { get; set; }
        [ForeignKey("Unit")]
        public int UnitID { get; set; }
        public int UnitsPerBox { get; set; }

        public Generic Generic { get; set; }
        public Producer Producer { get; set; }
        public Form Form { get; set; }
        public Concentration Concentration { get; set; }
        public Price Price { get; set; }
        public Unit Unit { get; set; }
        public ICollection<TradeNameSupp> TradeNameSupps { get; set; }
    }
}
