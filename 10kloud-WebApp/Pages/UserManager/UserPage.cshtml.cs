using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_WebApp.Pages.UserManager
{
    [Authorize(Roles ="admin")]

    public class UserPageModel : PageModel
    {
        private readonly IServiceUsers _userService;

        public UserPageModel(IServiceUsers UsersService)
        {
            _userService = UsersService;
        }

        public IEnumerable<User> Utenti { get; set; }

        public void OnGet()
        {
            Utenti = _userService.GetUsers();

        }
    }
}
