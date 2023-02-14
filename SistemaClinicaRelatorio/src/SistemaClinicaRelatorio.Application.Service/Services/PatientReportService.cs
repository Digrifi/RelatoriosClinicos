using SistemaClinicaRelatorio.Application.Service.DTOs;
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
                    birth = p.Person.BirthDate,
                    gender = p.Person.Gender,
                    medicalRecord = p.MRNumber,
                    fone = p.Endereco.Fone,
                    state = p.Endereco.State,
                    city = p.Endereco.City
                }).ToList();
        }
    }
}
