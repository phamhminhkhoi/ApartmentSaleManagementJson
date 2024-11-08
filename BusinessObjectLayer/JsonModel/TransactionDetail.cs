using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.JsonModel
{
    public class TransactionDetail
    {
        public int TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public int PropertyId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
