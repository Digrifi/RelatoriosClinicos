﻿using SistemaClinicaRelatorio.Domain.Contracts.Repositories;
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
    public class DoctorQueryReportService : IDoctorQueryReportService
    {
        private readonly IDoctorQueryRepository _repository;
        public DoctorQueryReportService(IDoctorQueryRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DoctorQueryReportDTO> FindAll()
        {
            return _repository.FindAll().
                Select(d => new DoctorQueryReportDTO()
                {
                    idDoctor = d.Doctor.Id,
                    nameDoctor = d.Doctor.Person.Name,
                    cnpj = d.Doctor.CNPJ,
                    crm = d.Doctor.CRM,
                    specialty = d.Doctor.Specialty.Name,
                    idService = d.Id,
                    pacient = d.Patient.Person.Name,
                    date = d.Date,
                    assessment = d.Evaluation
                }).ToList();
        }

        public Task<DoctorQueryReportDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<DoctorQueryReportDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorQueryReportDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(DoctorQueryReportDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
