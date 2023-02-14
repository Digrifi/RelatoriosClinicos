using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Domain.Entities
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Doctor>? DoctorList { get; set; }
    }
}
