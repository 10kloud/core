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
    public class Index3Model : PageModel
    {
        private readonly IServiceAlarms _alarmService;

        public Index3Model(IServiceAlarms alarmService)
        {
            _alarmService = alarmService;
        }

        public IEnumerable<Alarm> Allarmi { get; set; }
        public void OnGet()
        {
            Allarmi = _alarmService.GetBySilos(6);

        }
    }
}
