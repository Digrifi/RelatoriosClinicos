using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int StatusId { get; set; }
        public int ServiceNumbe { get; set; }
        public DateTime Date { get; set; }
        public string? Evaluation { get; set; }

        public int MedicalRecord { get; set; }
        public virtual Status? Status { get; set; }

        public virtual Patient? Patient { get; set; }
        public virtual Doctor? Doctor { get; set; }
    }
}
