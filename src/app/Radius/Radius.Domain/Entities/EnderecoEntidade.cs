using System;
using Flunt.Validations;
using System.Collections.Generic;
using System.Text;

namespace Radius.Domain.Entities
{
    public class EnderecoEntidade : BaseEntidade
    {

        public Guid ClienteId
        {
            get; private set;
        }

        //private void ConfigurarCleinteID(CadastroClienteEntidade Cliente)
        //{
        //    this.ClienteId = Cliente.Id;
        //}

        public string Logradouro
        {
            get; private set;
        }

        private void ConfigurarLogradouro(string logradouro)
        {
            this.Logradouro = logradouro;
        }

        public string Numero
        {
            get; private set;
        }

        private void ConfigurarNumero(string numero)
        {
            this.Numero = numero;
        }

        public string Complemento
        {
            get; private set;
        }

        private void ConfigurarComplemento(string complemento)
        {
            this.Complemento = complemento;
        }

        public string Bairro
        {
            get; private set;
        }

        private void ConfigurarBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public string CEP
        {
            get; private set;
        }
        private void ConfigurarCep(string cep)
        {
            this.CEP = cep;
        }


        public string Cidade
        {
            get; private set;
        }

        private void ConfiguraCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public string Estado
        {
            get; private set;
        }

        private void ConfiguraEstado(string uf)
        {
            this.Estado = uf;
        }

        public override void Validate()
        {
            AddNotifications(
                     new Contract()
                    .IsNotNullOrEmpty(Logradouro, "Logradouro", "É obrigatório o preenchimento do Logradouro.")
                    .IsNotNullOrEmpty(Numero, "Numero", "É obrigatório o preenchimento do Numero.")
                    .IsNotNullOrEmpty(Bairro, "Bairro", "É obrigatório o preenchimento do Bairro.")
                    .IsNotNullOrEmpty(CEP, "CEP", "É obrigatório o preenchimento do CEP.")
                    .IsNotNullOrEmpty(Cidade, "Cidade", "É obrigatório o preenchimento do Cidade.")
                    .IsNotNullOrEmpty(Estado, "Estado", "É obrigatório o preenchimento do Estado.")
                    

            );
        }


        /* Relacionamento */
        public CadastroClienteEntidade Cliente { get; set; }
    }
}
