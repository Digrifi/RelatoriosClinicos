using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public bool ConfirmedQuery { get; set; }
        public int StatusId { get; set; }
        public virtual Status? Status { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Doctor? Doctor { get; set; }
    }
}
