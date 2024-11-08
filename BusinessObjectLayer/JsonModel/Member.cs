using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.JsonModel
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Email { get; set; }
        public decimal? DollarPoint { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
    }
}
