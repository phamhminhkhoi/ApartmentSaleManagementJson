using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.JsonInterfaces
{
    public interface IMemberJsonService
    {
        public Member GetMemberByEmail(string email);

        public Member GetMemberById(int memberId);

        public List<Member> GetAllMembers();
    }
}
