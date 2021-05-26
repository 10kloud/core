using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_CRUD.Pages.SilosCharts
{
    public class IndexModel : PageModel
    {
        private readonly IServiceAlarms _alarmService;
        public IEnumerable<Alarm> Allarmi { get; set; }

        public IndexModel(IServiceAlarms alarmService)
        {
            _alarmService = alarmService;
        }

        public void OnGet()
        {
            Allarmi = _alarmService.GetBySilos(3);

        }
    }
}
