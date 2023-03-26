using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetIdentity.Pages.Account
{
    public class LoginModel : PageModel
    {
     
        public Credential credential { get; set; }
        public void OnGet()
        {
            this.credential = new Credential { UserName = "admin" };
        }
        public void OnPost()
        {

        }

        public class Credential
        {
            [Required]
            [Display(Name ="User Name")]
            public string UserName { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}
