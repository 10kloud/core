using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_WebApp.Pages.UserManager
{
    [Authorize(Roles = "admin")]

    public class UserCreateModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
