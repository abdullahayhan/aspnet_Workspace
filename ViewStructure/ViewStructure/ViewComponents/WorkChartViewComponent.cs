using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
    public class WorkChartViewComponent:ViewComponent
    {
        List<WorkChart> workCharts = new List<WorkChart>() 
        {
            new WorkChart("Abdullah",new List<bool>(){true,true,false,false,true }),
            new WorkChart("Mert",new List<bool>(){ false, false, true, false,true }),
            new WorkChart("Selin",new List<bool>(){ true, false, false, true, true }),
            new WorkChart("Merve",new List<bool>(){ false, false, true, false,true }),
        };
        public IViewComponentResult Invoke(int id)
        {
            return View(workCharts);
        }
    }
}
