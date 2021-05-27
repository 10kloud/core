using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore;
using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Services;
using _10kloud_infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _10kloud_CRUD.Pages.SilosCharts
{
    [Authorize]

    public class IndexModel : PageModel
    {
        public ApiConnection GetApi { get; set; }
        float Pressione;

        private readonly IServiceAlarms _alarmService;

        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Silos> Dati;
        public IEnumerable<Alarm> Allarmi { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IServiceAlarms alarmService)
        {
            _logger = logger;
            GetApi = new ApiConnection();
            _alarmService = alarmService;


       
        }

        public async Task OnGet()
        {
            Dati = await GetApi.GetLevel(3);
            Allarmi = _alarmService.GetBySilos(3);
           
        

            var x = User.IsInRole("admin");

        }

        public float Pressure()
        {
            float Pressione;
            Pressione = (float)Dati.FirstOrDefault<Silos>().pressureInternal;
            return Pressione;
        }
        public int Umidita()
        {
            float Umidita;
            Umidita = (float)Dati.FirstOrDefault<Silos>().humidityExternal;
            if (Umidita >= 1)
            {
                Umidita = 1;
            }
            Umidita = Umidita * 100;
            int Um = (int)Umidita;
            return Um;
        }
        public float Temperatura()
        {
            float Temperatura;
            Temperatura = (float)Dati.FirstOrDefault<Silos>().tempExternal;
            return Temperatura;
        }
    }
}
