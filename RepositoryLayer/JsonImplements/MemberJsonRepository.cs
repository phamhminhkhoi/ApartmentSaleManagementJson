using BusinessObjectLayer.JsonModel;
using DataAccessLayer.JsonDAO;
using RepositoryLayer.JsonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.JsonImplements
{
    public class MemberJsonRepository : IMemberJsonRepository
    {
        private readonly MemberDAO memberDAO;

        public MemberJsonRepository() 
        {
            memberDAO = new MemberDAO();
        }
        public List<Member> GetAllMembers()
        {
            return memberDAO.GetAllMembers();
        }

        public Member GetMemberByEmail(string email)
        {
            return memberDAO.GetMemberByEmail(email);
        }

        public Member GetMemberById(int memberId)
        {
            return memberDAO.GetMemberById(memberId);
        }
    }
}
