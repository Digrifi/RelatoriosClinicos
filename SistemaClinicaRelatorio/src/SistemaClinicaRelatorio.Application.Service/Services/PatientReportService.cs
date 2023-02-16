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
    public class PatientReportService : IPatientReportService
    {
        private readonly IPatientReportRepository _repository;
        public PatientReportService(IPatientReportRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PacientReportDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(p => new PacientReportDTO()
                {
                    id = p.Id,
                    name = p.Person.Name,
                    cpf = p.Person.CPF,
                    age = p.Person.Age,
                    //medicalRecord = p.MRNumber,
                    city = p.Person.Address.City,
                }).ToList();
        }

        public Task<PacientReportDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PacientReportDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PacientReportDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(PacientReportDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
