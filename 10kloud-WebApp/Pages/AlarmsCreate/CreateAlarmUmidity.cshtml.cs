using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_CRUD.Pages.AlarmsCreate
{
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
                    _alarmService.Insert(Input);
                    return RedirectToPage("AlarmsTables/UmidityAlarmTables");
                }
                return Page();
            }
        }
}
