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

        public IEnumerable<Silos> Dati;
        public IEnumerable<Alarm> Allarmi { get; set; }


        public ChartsSilos2Model(ILogger<IndexModel> logger, IServiceAlarms alarmService)
        {
            _logger = logger;
            GetApi = new ApiConnection();
            _alarmService = alarmService;

        }

        public async Task OnGet()
        {
            Dati = await GetApi.GetLevel(2);
            Allarmi = _alarmService.GetBySilos(2);

            var x = User.IsInRole("admin");

        }
        public float Pressure()
        {
            float Pressione;
            Pressione = (float)Dati.FirstOrDefault<Silos>().pressureInternal;
            return Pressione;
        }
        public float Umidita()
        {
            float Umidita;
            Umidita = (float)Dati.FirstOrDefault<Silos>().humidityExternal;
            if (Umidita >= 1)
            {
                Umidita = 1;
            }
            Umidita = Umidita * 100;
            return Umidita;
        }
        public float Temperatura()
        {
            float Temperatura;
            Temperatura = (float)Dati.FirstOrDefault<Silos>().tempExternal;
            return Temperatura;
        }
    }

}
