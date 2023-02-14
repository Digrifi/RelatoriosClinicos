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
    public class PatientReportService
    {
        private readonly PatientReportRepository _repository;
        public PatientReportService(PatientReportRepository repository)
        {
            _repository = repository;
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
    }
}
