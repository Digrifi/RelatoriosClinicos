using SistemaClinicaRelatorio.Domain.DTO;
using SistemaClinicaRelatorio.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Application.Service.Services
{
    public class MonthQueriesReportService
    {
        private readonly MonthQueriesReportRepository _repository;
        public MonthQueriesReportService(MonthQueriesReportRepository repository)
        {
            _repository = repository;
        }

        public List<MonthQueriesReportDTO> FindAll()
        {
            return _repository.FindAll().
                Select(d => new MonthQueriesReportDTO()
                {
                    idService = d.Id,
                    pacient = d.Pacient.Person.Name,
                    doctor = d.Doctor.Person.Name,
                    specialty = d.Doctor.Specialty.Name,
                    date = d.Date,
                    assessment = d.Assessment
                }).ToList();
        }
    }
}
