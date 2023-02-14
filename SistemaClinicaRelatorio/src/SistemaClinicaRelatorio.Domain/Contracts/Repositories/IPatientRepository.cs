using SistemaClinicaRelatorio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Domain.Contracts.Repositories
{
    internal interface IPatientRepository : IBaseRepository<Patient>
    {
    }
}
