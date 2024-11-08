using BusinessObjectLayer.JsonModel;
using RepositoryLayer.Interfaces;
using RepositoryLayer.JsonInterfaces;
using ServiceLayer.JsonInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.JsonImplements
{
    public class MemberJsonService : IMemberJsonService
    {
        private readonly IMemberJsonRepository _memberRepository;
        public MemberJsonService(IMemberJsonRepository memberRepository)
        {
            this._memberRepository = memberRepository;
        }

        public List<Member> GetAllMembers()
        {
           return _memberRepository.GetAllMembers();
        }

        public Member GetMemberByEmail(string email)
        {
            return _memberRepository.GetMemberByEmail(email);
        }

        public Member GetMemberById(int memberId)
        {
            return _memberRepository.GetMemberById(memberId);
        }
    }
}
