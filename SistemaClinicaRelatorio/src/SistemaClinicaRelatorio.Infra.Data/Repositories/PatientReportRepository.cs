using SistemaClinicaRelatorio.Domain.Contracts.Repositories;
using SistemaClinicaRelatorio.Domain.Entities;
using SistemaClinicaRelatorio.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Infra.Data.Repositories
{
    public class PatientReportRepository : BaseRepository<Patient>, IPatientReportRepository
    {
        private readonly SQLServerContext _context;
        public PatientReportRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
