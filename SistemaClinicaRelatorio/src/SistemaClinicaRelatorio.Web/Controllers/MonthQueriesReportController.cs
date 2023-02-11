using Microsoft.AspNetCore.Mvc;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class MonthQueriesReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
