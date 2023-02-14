using System.ComponentModel;

namespace SistemaClinicaRelatorio.Application.Service.DTOs
{
    public class MonthQueriesReportDTO
    {
        [DisplayName("Código Consulta")]
        public int idService { get; set; }
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
