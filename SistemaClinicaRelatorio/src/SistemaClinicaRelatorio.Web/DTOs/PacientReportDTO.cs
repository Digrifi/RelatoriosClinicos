using System.ComponentModel;


namespace SistemaClinicaRelatorio.Web.DTOs
{
    public class PacientReportDTO
    {
        #region Adicionando os Services
        private readonly IPessoaService _pessoaService;
        private readonly IEnderecoService _enderecoService;
        private readonly IPacienteService _pacienteService;
        public PacientReportDTO(IPessoaService service, IEnderecoService uFServices, IPacienteService fornecedorService)
        {
            _pessoaService = service;
            _enderecoService = uFServices;
            _pacienteService = fornecedorService;
        }
        #endregion

        #region Pessoa
        [DisplayName("Código")]
        public int id { get; set; }
        [DisplayName("Nome")]
        public string name { get; set; }
        [DisplayName("CPF")]
        public string cpf { get; set; }
        [DisplayName("Data de Nascimento")]
        public string birth { get; set; }
        #endregion

        #region Endereço
        [DisplayName("Telefone")]
        public string fone { get; set; }
        [DisplayName("Estado")]
        public string state { get; set; }
        [DisplayName("Cidade")]
        public string city { get; set; }
        #endregion

        #region Paciente
        [DisplayName("Número Prontuario")]
        public string medicalRecord { get; set; }
        #endregion

        public PacientReportDTO MapToDTO(int id)
        {
            #region pessoa, endereco e paciente
            // essa parte podemos eliminar, mas acho que fica mais facil de visualizar
            // talvez tenhamos que criar a função FindById(int id);
            var pessoa = _servicePessoa.FindById(id);
            var endereco = _serviceEndereco.FindByPessoaId(id);
            var paciente = _servicePaciente.FindByPessoaId(id);
            #endregion
            return new PacientReportDTO
            {
                id = id,

                #region Pessoa
                name = pessoa.name,
                cpf = pessoa.cpf,
                birth = pessoa.birth,
                #endregion

                #region Endereço
                fone  = endereco.fone,
                city  = endereco.city,
                state = endereco.state,
                #endregion

                #region Paciente
                medicalRecord = paciente.medicalRecord,
                #endregion
            };
        }

        public virtual ICollection<PacientReportDTO> ListaPacientReport()
        {
            
            return _pacienteService.FindAll().Select(p => new MapToDTO(p.id)).ToList();

        }

        // Criei aqui, mas acredito que teremos ainda que encontrar o lugar ideal
        /*
        


        */



    }
}
