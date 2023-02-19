using Microsoft.AspNetCore.Mvc;
using SistemaClinicaRelatorio.Application.Service.Services;
using SistemaClinicaRelatorio.Domain.Contracts.Services;
using SistemaClinicaRelatorio.Domain.Entities;

namespace SistemaClinicaRelatorio.Web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IDoctorQueryReportService _doctorReportService;
        private readonly IDoctorService _doctorService;
        private readonly IPatientReportService _patientService;
        private readonly IMonthQueriesReportService _monthService;
        public ReportsController(IDoctorQueryReportService doctorReportService, IDoctorService doctorService, IPatientReportService patientService, IMonthQueriesReportService montService)
        {
            _doctorReportService = doctorReportService;
            _doctorService = doctorService;
            _patientService = patientService;
            _monthService = montService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Doctors() 
        {
            return View(_doctorService.FindAll());
        }

        public async Task<IActionResult> DoctorQueryReport(int id)
        {
            return View(_doctorReportService.FindAll()
                        .Where(d => d.idDoctor == id));
        }
        public async Task<IActionResult> PatientReport()
        {
            return View(_patientService.FindAll());
        }
        public async Task<IActionResult> MonthQueriesReport(int month, int year)
        {
            return View(_monthService.FindAll()
                        .Where(m => m.date.Month == month && m.date.Year == year));
        }
    }
}
