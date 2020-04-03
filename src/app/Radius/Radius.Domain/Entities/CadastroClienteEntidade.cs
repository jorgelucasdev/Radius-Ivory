using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Radius.Domain.Entities
{
    public class CadastroClienteEntidade : BaseEntidade
    {
        public string CNPJ
        {
            get; private set;
        }

        private void ConfigurarCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
        }

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
        public string Endereco
        {
            get; private set;
        }

        private void ConfigurarEndereco(string endereco)
        {
            this.Endereco = endereco;
        }

        public string CEP
        {
            get; private set;
        }
        private void ConfigurarCep(string cep)
        {
            this.CEP = cep;
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

        public override void Validate()
        {
            AddNotifications(
                      new Contract()
                     .IsNotNullOrEmpty(CNPJ, "CNPJ", "É obrigatório o preenchimento do CNPJ.")
                     .IsNotNullOrEmpty(RazaoSocial, "RazaoSocial", "É obrigatório o preenchimento da Razão Social.")
                     .IsNotNullOrEmpty(NomeFantasia, "NomeFantasia", "É obrigatório o preenchimento do Nome Fantasia.")
                     .IsNotNullOrEmpty(Endereco, "Endereco", "É obrigatório o preenchimento do Endereco.")
                     .IsNotNullOrEmpty(CEP, "CEP", "É obrigatório o preenchimento do CEP.")
                     .IsNotNullOrEmpty(Telefone, "Telefone", "É obrigatório o preenchimento do Telefone.")
                     .IsNotNullOrEmpty(Email, "Email", "É obrigatório o preenchimento do Email.")
                     .IsNullOrNullable(DataCadastro, "DataCadastro", "É obrigatório o preenchimento do Endereço.")
                     .IsNullOrNullable(DataEncerramento, "DataEncerramento", "É obrigatório o preenchimento do Endereço.")
                     
             );
        }
    }

}
