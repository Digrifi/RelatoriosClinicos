using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class PatientReportController : Controller
    {
        private readonly PatientReportService _service;
        public PatientReportController(PatientReportService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }
    }
}
