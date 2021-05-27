using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using _10kloud_AppCore;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using _10kloud_infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _10kloud_CRUD.Pages.SilosCharts
{
    [Authorize]
    public class ChartsSilos2Model : PageModel
    {
        public ApiConnection GetApi { get; set; }

        private readonly IServiceAlarms _alarmService;



        private readonly ILogger<IndexModel> _logger;
        public Silos Dati;




        public ChartsSilos2Model(IServiceAlarms alarmService)
        {
            _alarmService = alarmService;
            GetApi = new ApiConnection();


        }
        public IEnumerable<Alarm> Allarmi { get; set; }

        public async void OnGet()
        {
            //Dati = await GetApi.GetSingleData(2);

            Allarmi = _alarmService.GetBySilos(2);

        }
    }

}
