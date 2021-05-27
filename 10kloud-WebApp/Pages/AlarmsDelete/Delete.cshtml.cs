using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_CRUD.Pages.AlarmsDelete
{
    [Authorize]

    public class DeleteModel : PageModel
    {
        private readonly IServiceAlarms _alarmService;

        public DeleteModel(IServiceAlarms alarmService)
        {
            _alarmService = alarmService;
        }
        public Alarm Input { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost(int id)
        {

            _alarmService.Delete(id);
            return RedirectToPage("/AlarmsTables/PressionAlarmTables");


        }
    }
}
