using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class DoctorQueryReportController : Controller
    {
        private readonly DoctorQueryReportService _service;
        public DoctorQueryReportController(DoctorQueryReportService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int id)
        {
            return View(_service.FindAll()
                        .Where(d => d.idDoctor == id));
        }
    }
}
