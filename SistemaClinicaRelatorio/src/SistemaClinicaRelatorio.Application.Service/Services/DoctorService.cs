using SistemaClinicaRelatorio.Domain.Contracts.Repositories;
using SistemaClinicaRelatorio.Domain.Contracts.Services;
using SistemaClinicaRelatorio.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Application.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;
        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DoctorDTO> FindAll()
        {
            return _repository.FindAll()
                            .Select(d => new DoctorDTO()
                            {
                                id = d.Id,
                                person = new PersonDTO()
                                {
                                    id = d.Person.Id,
                                    name = d.Person.Name
                                }
                            }).ToList();
        }

        public Task<DoctorDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<DoctorDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(DoctorDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
