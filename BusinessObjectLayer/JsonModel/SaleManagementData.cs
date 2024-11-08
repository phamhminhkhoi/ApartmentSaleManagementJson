using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.JsonModel
{
    public class SaleManagementData
    {
        public List<PropertyCategory> PropertyCategories { get; set; }
        public List<Property> Properties { get; set; }
        public List<RoleUser> RoleUsers { get; set; }
        public List<Member> Members { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<TransactionDetail> TransactionDetails { get; set; }
    }
}
