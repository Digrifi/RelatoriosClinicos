using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;
using SistemaClinicaRelatorio.Domain.Contracts.Services;
using SistemaClinicaRelatorio.Domain.Entities;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IDoctorQueryReportService _doctorService;
        private readonly IPatientReportService _patientService;
        private readonly IMonthQueriesReportService _monthService;
        public ReportsController(DoctorQueryReportService doctorService, PatientReportService patientService, IMonthQueriesReportService montService)
        {
            _doctorService = doctorService;
            _patientService = patientService;
            _monthService = montService;
        }

        public async Task<IActionResult> DoctorQueryReport(int id)
        {
            return View(_doctorService.FindAll()
                        .Where(d => d.idDoctor == id));
        }
        public async Task<IActionResult> PatientReport(int id)
        {
            return View(_patientService.FindAll());
        }
        public IActionResult MonthQueriesReport(int month)
        {
            return View(_monthService.FindAll()
                        .Where(m => m.date.Month == month));
        }
    }
}
