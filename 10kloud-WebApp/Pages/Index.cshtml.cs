using _10kloud_AppCore;
using _10kloud_AppCore.Interfaces.Services;
using _10kloud_infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10kloud_WebApp.Pages
{

    
    [Authorize]
    public class IndexModel : PageModel
    {
        public ApiConnection GetApi{ get; set; }
        
        private readonly IServiceAlarms _ServiceAlarms;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            GetApi = new ApiConnection();
        }

        public async Task OnGet()
        {
            IEnumerable<Silos> dati= await GetApi.GetData();
       

        }
    }
}
