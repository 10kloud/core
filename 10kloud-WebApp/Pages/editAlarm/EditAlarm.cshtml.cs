using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_CRUD.Pages.editAlarm
{
    public class EditAlarmModel : PageModel
    {
        private readonly IServiceAlarms _alarmService;
        public Alarm Input { get; set; }

        public EditAlarmModel(IServiceAlarms alarmService)
        {
            _alarmService = alarmService;
        }

        public void OnGet(int id)
        {
            Input = _alarmService.Get(id);

        }
        public IActionResult OnPost(int id)
        {

            if (ModelState.IsValid)
            {
                Input.Id = id;
                _alarmService.Update(Input);
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
