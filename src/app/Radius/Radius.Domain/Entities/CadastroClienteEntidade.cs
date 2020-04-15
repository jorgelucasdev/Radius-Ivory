using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;

namespace Radius.Domain.Entities
{
    public class CadastroClienteEntidade : BaseEntidade
    {

        public string RazaoSocial
        {
            get; private set;
        }

        private void ConfigurarRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
        }

        public string NomeFantasia
        {
            get; private set;
        }
        private void ConfigurarNomeFantasia(string nomeFantasia)
        {
            this.NomeFantasia = nomeFantasia;
        }

        public string CNPJ
        {
            get; private set;
        }

        private void ConfigurarCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
        }

        public string Telefone
        {
            get; private set;
        }

        private void ConfigurarTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string Email
        {
            get; private set;
        }

        private void ConfigurarEmail(string email)
        {
            this.Email = email;
        }


        public DateTime? DataCadastro
        {
            get; private set;
        }

        public void ConfigurarDataCadstro()
        {
            this.DataCadastro = DataCadastro;
        }

        public DateTime? DataEncerramento
        {
            get; private set;
        }

        public void ConfigurarDataEncerramento()
        {
            this.DataEncerramento = DataEncerramento;
        }


        public EnderecoEntidade Endereco
        {
            get; private set;
        }

        private void Configurarendereco(EnderecoEntidade endereco)
        {
            this.Endereco = endereco;
        }


        public override void Validate()
        {
            AddNotifications(
                      new Contract()
                     .IsNotNullOrEmpty(RazaoSocial, "RazaoSocial", "É obrigatório o preenchimento da RazãoSocial.")
                     .IsNotNullOrEmpty(NomeFantasia, "NomeFantasia", "É obrigatório o preenchimento do NomeFantasia.")
                     .IsNotNullOrEmpty(CNPJ, "CNPJ", "É obrigatório o preenchimento do CNPJ.")
                     .IsNotNullOrEmpty(Telefone, "Telefone", "É obrigatório o preenchimento do Telefone.")
                     .IsNotNullOrEmpty(Email, "Email", "É obrigatório o preenchimento do Email.")
                     .IsNull(DataCadastro, "DataCadastro", "É obrigatório o preenchimento da DataCadastro.")
                     .IsNull(DataEncerramento, "DataEncerramento", "É obrigatório o preenchimento da DataEncerramento.")
             );
        }


        /* EF Relacioanamento*/
        public IEnumerable<ProjetoEntidade> Projetos { get; set; }
    }

}
