using SistemaClinicaRelatorio.Domain.Contracts.Repositories;
using SistemaClinicaRelatorio.Domain.Contracts.Services;
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
    public class MonthQueriesReportService : IMonthQueriesReportService
    {
        private readonly IMonthQueriesReportRepository _repository;
        public MonthQueriesReportService(IMonthQueriesReportRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MonthQueriesReportDTO> FindAll()
        {
            return _repository.FindAll().
                Select(d => new MonthQueriesReportDTO()
                {
                    idService = d.Id,
                    pacient = d.Patient.Person.Name,
                    doctor = d.Doctor.Person.Name,
                    specialty = d.Doctor.Specialty.Name,
                    date = d.Date,
                    assessment = d.Evaluation
                }).ToList();
        }

        public Task<MonthQueriesReportDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MonthQueriesReportDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MonthQueriesReportDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(MonthQueriesReportDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
