using System.ComponentModel;

namespace SistemaDeClinicasRelatorios.Web.DTO
{
    public class DoctorQueryReportDTO
    {
        [DisplayName("Código Médico")]
        public int idDoctor { get; set; }
        [DisplayName("Nome Médico")]
        public string nameDoctor { get; set; }
        [DisplayName("CPF")]
        public string cpf { get; set; }
        [DisplayName("CRM")]
        public string crm { get; set; }
        [DisplayName("Especialidade")]
        public string specialty { get; set; }
        [DisplayName("Código Atendimento")]
        public int idService { get; set; }
        [DisplayName("Paciente")]
        public string pacient { get; set; }
        [DisplayName("Data")]
        public DateTime date { get; set; }
        [DisplayName("Avaliação")]
        public string assessment { get; set; }
    }
}
