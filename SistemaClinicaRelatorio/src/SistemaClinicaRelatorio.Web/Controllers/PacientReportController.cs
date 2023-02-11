using Microsoft.AspNetCore.Mvc;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class PacientReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
