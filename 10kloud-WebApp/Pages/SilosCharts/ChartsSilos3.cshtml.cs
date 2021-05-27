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
            Dati = await GetApi.GetLevel(3);

            var x = User.IsInRole("admin");
        }
    }
}
