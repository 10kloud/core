using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10kloud_AppCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10kloud_CRUD.Pages.AlarmsTables
{
    public class PressionAlarmTablesModel : PageModel
    {
        private readonly IServiceAlarms _alarmService;
        public void OnGet()
        {
            _alarmService.GetByAlarmingParameter("pressione");
        }
    }
}
