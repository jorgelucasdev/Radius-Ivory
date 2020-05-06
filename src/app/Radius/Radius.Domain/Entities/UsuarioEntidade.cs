using System;
using Flunt.Validations;
using System.Collections.Generic;
using System.Text;

namespace Radius.Domain.Entities
{
    public class UsuarioEntidade : BaseEntidade
    {
        public string CPF
        {
            get; private set;
        }

        private void ConfigurarCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public string Nome
        {
            get; private set;
        }

        private void ConfigurarNome(string nome)
        {
            this.Nome = nome;
        }


        public string Email
        {
            get; private set;
        }

        private void ConfigurarEmaill(string email)
        {
            this.Email = email;
        }

        public string Celular
        {
            get; private set;
        }

        private void ConfigurarCelular(string celular)
        {
            this.Celular = celular;
        }

        public string Whatsapp
        {
            get; private set;
        }

        private void ConfigurarWhatsapp(string whatsapp)
        {
            this.Whatsapp = whatsapp;
        }

        public string Telefone
        {
            get; private set;
        }

        private void ConfigurarTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string Setor
        {
            get; private set;
        }

        private void ConfigurarSetor(string setor)
        {
            this.Setor = setor;
        }

        public string Cargo
        {
            get; private set;
        }

        private void ConfigurarCargo(string cargo)
        {
            this.Cargo = cargo;
        }

        public DateTime Aniversario
        {
            get; private set;
        }

        private void ConfigurarAniversario(DateTime aniversario)
        {
            this.Aniversario = aniversario;
        }

        public DateTime DataInicio
        {
            get; private set;
        }

        private void ConfigurarDataInicio(DateTime dataInicio)
        {
            this.DataInicio = dataInicio;
        }

        public DateTime DataFim
        {
            get; private set;
        }

        private void ConfigurarDataFim(DateTime dataFim)
        {
            this.DataFim = dataFim;
        }

        public string Status
        {
            get; private set;
        }

        private void ConfigurarStatus(string status)
        {
            this.Status = status;
        }

        public string Observacoes
        {
            get; private set;
        }

        private void ConfigurarObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
        }

        public override void Validate()
        {
            AddNotifications(
                     new Contract()
                    .IsNotNullOrEmpty(CPF, "CPF", "É obrigatório o preenchimento da CPF.")
                    .IsNotNullOrEmpty(Nome, "Nome", "É obrigatório o preenchimento do Nome.")
                    .IsNotNullOrEmpty(Email, "Email", "É obrigatório o preenchimento do Email.")
                    .IsNull(Aniversario, "Aniversario", "É obrigatório o preenchimento da Data de Aniversario.")
                    .IsNull(DataInicio, "DataInicio", "É obrigatório o preenchimento da Data Inicio.")
                    .IsNull(DataFim, "DataFim", "É obrigatório o preenchimento da Data Termino.")
                    .IsNotNullOrEmpty(Status, "Status", "É obrigatório o preenchimento do Status.")
            );
        }
    }
}
