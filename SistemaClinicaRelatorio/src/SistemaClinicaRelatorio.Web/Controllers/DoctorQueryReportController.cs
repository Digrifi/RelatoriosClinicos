using Microsoft.AspNetCore.Mvc;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class DoctorQueryReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
