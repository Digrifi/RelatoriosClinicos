using SistemaClinicaRelatorio.Domain.Enums;
using System.ComponentModel;

namespace SistemaClinicaRelatorio.Domain.DTO
{
    public class PacientReportDTO
    {
        [DisplayName("Código")]
        public int id { get; set; }
        [DisplayName("Nome")]
        public string name { get; set; }
        [DisplayName("Número Prontuario")]
        public string medicalRecord { get; set; }
        [DisplayName("CPF")]
        public string cpf { get; set; }
        [DisplayName("Gênero")]
        public GenderEnum gender { get; set; }
        [DisplayName("Telefone")]
        public string fone { get; set; }
        [DisplayName("Idade")]
        public string age { get; set; }
        [DisplayName("Estado")]
        public string state { get; set; }
        [DisplayName("Cidade")]
        public string city { get; set; }
    }
}
