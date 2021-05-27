using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_WebApp.Pages.UserManager
{
    [Authorize(Roles = "admin")]

    public class UserDeleteModel : PageModel
    {
        private readonly IServiceUsers _userService;

        public UserDeleteModel(IServiceUsers userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
            //_userService.Delete();

        }
        public IActionResult OnPost(string Id)
        {

            _userService.Delete(Id);
            return RedirectToPage("/UserManager/UserPage");


        }

    }
}
