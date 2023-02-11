using System.ComponentModel;

namespace SistemaDeClinicasRelatorios.Web.DTO
{
    public class MonthQueriesReport
    {
        [DisplayName("Código Consulta")]
        public int id { get; set; }
        [DisplayName("Paciente")]
        public string pacient { get; set; }
        [DisplayName("Médico")]
        public string doctor { get; set; }
        [DisplayName("Especialidade")]
        public string specialty { get; set; }
        [DisplayName("Data")]
        public DateTime date { get; set; }
        [DisplayName("Avaliação")]
        public string assessment { get; set; }
    }
}
