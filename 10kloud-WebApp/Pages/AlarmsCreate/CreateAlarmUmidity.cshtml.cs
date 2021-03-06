using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_CRUD.Pages.AlarmsCreate
{
    [Authorize]

    public class CreateAlarmUmidityModel : PageModel
    {
        private readonly IServiceAlarms _alarmService;

        public CreateAlarmUmidityModel(IServiceAlarms alarmService)
        {
            _alarmService = alarmService;
        }

        [BindProperty]
        public Alarm Input { get; set; }

        public void OnGet()
        {
            Input = new Alarm();

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Input.User_Email = User.Identity.Name;
                Input.Alarming_Parameter = "umidita";

                _alarmService.Insert(Input);
                return RedirectToPage("/AlarmsTables/UmidityAlaramTables");
            }
            return Page();
        }
    }
}
