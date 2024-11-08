using BusinessObjectLayer.JsonModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer.Interfaces;
using ServiceLayer.JsonInterfaces;

namespace PresentationLayer.Pages
{
    public class LoginModel : PageModel
    {
        private IMemberJsonService _memberService { get; set; }

        public LoginModel(IMemberJsonService memberService)
        {
            this._memberService = memberService;
        }
        public void OnPost()
        {
            string email = Request.Form["txtEmail"];
            string password = Request.Form["txtPassword"];
            Member member = _memberService.GetMemberByEmail(email);
            if (member != null && member.Password.Equals(password))
            {
                int roleId = member.RoleId;
				HttpContext.Session.SetString("RoleID", roleId.ToString());
				Response.Redirect("/AdminPanel/Admin");
			}
        }
    }
}
