using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.JsonModel
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
