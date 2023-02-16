using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;
using SistemaClinicaRelatorio.Domain.Contracts.Services;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class PatientReportController : Controller
    {
        private readonly IPatientReportService _service;
        public PatientReportController(IPatientReportService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }
    }
}
