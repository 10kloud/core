using _10kloud_AppCore;
using _10kloud_AppCore.Interfaces.Services;
using _10kloud_infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _10kloud_WebApp.Pages
{


    //[Authorize(Roles ="admin")]
    [Authorize]
    public class IndexModel : PageModel
    {
        public ApiConnection GetApi { get; set; }

        private readonly IServiceAlarms _ServiceAlarms;

        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Silos> Dati;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            GetApi = new ApiConnection();

        }

        public async Task OnGet()
        {
            Dati = await GetApi.GetData();

            var x = User.IsInRole("admin");
        }
    }
    public static class JavaScriptConvert
    {
        public static HtmlString SerializeObject(object value)
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
