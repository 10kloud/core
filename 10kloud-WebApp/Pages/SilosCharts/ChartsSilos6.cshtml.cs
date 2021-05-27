using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using _10kloud_infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _10kloud_CRUD.Pages.SilosCharts
{
    public class Index3Model : PageModel
    {
        public ApiConnection GetApi { get; set; }

        private readonly IServiceAlarms _alarmService;

        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Silos> Dati;
        public IEnumerable<Alarm> Allarmi { get; set; }


        public Index3Model(ILogger<IndexModel> logger, IServiceAlarms alarmService)
        {
            _logger = logger;
            GetApi = new ApiConnection();
            _alarmService = alarmService;

        }

        public async Task OnGet()
        {
            Dati = await GetApi.GetLevel(6);
            Allarmi = _alarmService.GetBySilos(6);

            var x = User.IsInRole("admin");

        }
    }
}
