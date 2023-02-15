using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;
using SistemaClinicaRelatorio.Domain.Contracts.Services;
using SistemaClinicaRelatorio.Domain.Entities;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly DoctorQueryReportService _doctorService;
        private readonly PatientReportService _patientService;
        public ReportsController(DoctorQueryReportService doctorService, PatientReportService patientService)
        {
            _doctorService = doctorService;
            _patientService = patientService;
        }

        public async Task<IActionResult> DoctorQueryReport(int id)
        {
            return View(_doctorService.FindAll()
                        .Where(d => d.idDoctor == id));
        }
        public async Task<IActionResult> Index(int id)
        {
            return View(_patientService.FindAll());
        }
    }
}
