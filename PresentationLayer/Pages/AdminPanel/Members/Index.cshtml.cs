using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer.JsonModel;
using ServiceLayer.Interfaces;
using ServiceLayer.JsonInterfaces;

namespace PresentationLayer.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly IMemberJsonService _memberService;

        public IndexModel(IMemberJsonService memberService)
        {
            _memberService = memberService;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync(string searchTerm)
        {
            var listToShow = _memberService.GetAllMembers();
            var checkedRole = new List<Member>();
            foreach (var member in listToShow) 
            {
                if(member.RoleId == 2 || member.RoleId == 3|| member.RoleId == 4) {  checkedRole.Add(member); }
            }
            Member = checkedRole;
        }
    }
}
