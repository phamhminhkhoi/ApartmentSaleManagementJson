using BusinessObjectLayer.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.JsonInterfaces
{
    public interface IMemberJsonRepository
    {
        public Member GetMemberByEmail(string email);

        public Member GetMemberById(int memberId);

        public List<Member> GetAllMembers();
    }
}
