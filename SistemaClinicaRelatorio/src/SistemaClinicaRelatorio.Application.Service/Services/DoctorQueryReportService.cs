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
    public class DoctorQueryReportService
    {
        private readonly DoctorQueryReportRepository _repository;
        public DoctorQueryReportService(DoctorQueryReportRepository repository)
        {
            _repository = repository;
        }

        public List<DoctorQueryReportDTO> FindAll()
        {
            return _repository.FindAll().
                Select(d => new DoctorQueryReportDTO()
                {
                    idDoctor = d.Doctor.Id,
                    nameDoctor = d.Doctor.Person.Name,
                    cnpj = d.Doctor.Person.CNPJ,
                    crm = d.Doctor.CRM,
                    specialty = d.Doctor.Specialty.Name,
                    idService = d.Id,
                    pacient = d.Pacient.Person.Name,
                    date = d.Date,
                    assessment = d.Assessment
                }).ToList();
        }
    }
}
