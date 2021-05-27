using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public class ChartsSilos1Model : PageModel
    {
        public ApiConnection GetApi { get; set; }

        private readonly IServiceAlarms _alarmService;

        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Silos> Dati;

        public ChartsSilos1Model(ILogger<IndexModel> logger, IServiceAlarms alarmService)
        {
            _logger = logger;
            GetApi = new ApiConnection();
            _alarmService = alarmService;

        }

        public IEnumerable<Alarm> Allarmi { get; set; }

        public async  void OnGet()
        {
            Allarmi = _alarmService.GetBySilos(1);
           Dati = await GetApi.GetData();
        }
    }
    


    public static class JavaScriptConvert
    {
        public static 
            HtmlString SerializeObject(object value)
        {
            using (var stringWriter = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                var serializer = new JsonSerializer
                {
                    // Let's use camelCasing as is common practice in JavaScript
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };

                // We don't want quotes around object names
                jsonWriter.QuoteName = false;
                serializer.Serialize(jsonWriter, value);

                return new HtmlString(stringWriter.ToString());
            }
        }

    }

}
