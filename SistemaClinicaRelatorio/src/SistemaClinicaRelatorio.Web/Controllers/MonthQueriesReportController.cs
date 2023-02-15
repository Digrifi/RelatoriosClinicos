using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class MonthQueriesReportController : Controller
    {
        private readonly MonthQueriesReportService _service;
        public MonthQueriesReportController(MonthQueriesReportService service)
        {
            _service = service;
        }

        public IActionResult Index(int month)
        {
            return View(_service.FindAll()
                        .Where(m => m.date.Month == month));
        }
    }
}
