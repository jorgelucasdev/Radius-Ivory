using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Radius.Domain.Entities
{
    public class ProjetoEntidade : BaseEntidade
    {

        public Guid ClienteId
        {
            get; private set;
        }

        public string Empresa
        {
            get; private set;
        }

        private void ConfigurarEmpresa(string empresa)
        {
            this.Empresa = empresa;
        }

        public string CNPJ
        {
            get; private set;
        }

        private void ConfigurarCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
        }


        public string Cidade
        {
            get; private set;
        }

        private void ConfigurarCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public string Estado
        {
            get; private set;
        }

        private void ConfigurarEstado(string uf)
        {
            this.Estado = uf;
        }

        public string Responsavel
        {
            get; private set;
        }

        private void ConfigurarResponsavel(string responsavel)
        {
            this.Responsavel = responsavel;
        }


        public string SetorR
        {
            get; private set;
        }

        private void ConfigurarSetor(string setor)
        {
            this.SetorR = setor;
        }


        public string TelefoneR
        {
            get; private set;
        }

        private void ConfigurarTelefone(string telefone)
        {
            this.TelefoneR = telefone;
        }

        public string EmailR
        {
            get; private set;
        }

        private void ConfigurarEmail(string email)
        {
            this.EmailR = email;
        }

        public string Corresponsavel
        {
            get; private set;
        }

        private void ConfigurarCorresponsavel(string corresponsavel)
        {
            this.Corresponsavel = corresponsavel;
        }

        public string SetorC
        {
            get; private set;
        }

        private void ConfigurarSetorC(string setor)
        {
            this.SetorC = setor;
        }

        public string TelefoneC
        {
            get; private set;
        }

        private void ConfigurarTelefoneC(string telefone)
        {
            this.TelefoneC = telefone;
        }

        public string EmailC
        {
            get; private set;
        }

        private void ConfigurarEmailC(string email)
        {
            this.EmailC = email;
        }

        public string NomeProjeto
        {
            get; private set;
        }

        private void ConfigurarProjeto(string nomeProjeto)
        {
            this.NomeProjeto = nomeProjeto;
        }

        public string Segmento
        {
            get; private set;
        }

        private void ConfigurarSegmento(string segmento)
        {
            this.Segmento = segmento;
        }

        public DateTime? DataInicio

        {
            get; private set;
        }

        public void ConfigurarDataInicio()
        {
            this.DataInicio = DataInicio;
        }

        public DateTime? DataTermino
        {
            get; private set;
        }

        public void ConfigurarDataTermino()
        {
            this.DataTermino = DataTermino;
        }

        public string Apresentacao
        {
            get; private set;
        }

        private void ConfigurarApresentação(string apresentacao)
        {
            this.Apresentacao = apresentacao;
        }

        public string Descricao
        {
            get; private set;
        }

        private void ConfigurarDescricao(string descricao)
        {
            this.Descricao = Descricao;
        }

        public string Justificativa
        {
            get; private set;
        }

        private void ConfigurarJustificativa(string justificativa)
        {
            this.Justificativa = justificativa;
        }


        public string ObjetivoGeral
        {
            get; private set;
        }

        private void ConfigurarObjetivoGeral(string objetivoGeral)
        {
            this.ObjetivoGeral = objetivoGeral;
        }

        public string ObjetivoEspecifico
        {
            get; private set;
        }

        private void ConfigurarObjetivoEspecifico(string objetivoEspecifico)
        {
            this.ObjetivoEspecifico = objetivoEspecifico;
        }


        public override void Validate()
        {
            AddNotifications(
                     new Contract()
                    .IsNotNullOrEmpty(Empresa, "Empresa", "É obrigatório o preenchimento da Empresa.")
                    .IsNotNullOrEmpty(CNPJ, "CNPJ", "É obrigatório o preenchimento do CNPJ.")
                    .IsNotNullOrEmpty(Responsavel, "Responsavel", "É obrigatório o preenchimento do Responsavel.")
                    .IsNotNullOrEmpty(SetorR, "SetorR", "É obrigatório o preenchimento do Setor do Responsavel.")
                    .IsNotNullOrEmpty(TelefoneR, "TelefoneR", "É obrigatório o preenchimento do Telefone do Responsavel.")
                    .IsNotNullOrEmpty(EmailR, "EmailR", "É obrigatório o preenchimento do Email do Responsavel.")
                    .IsNotNullOrEmpty(Corresponsavel, "Corresponsavel", "É obrigatório o preenchimento do Corresponsavel.")
                    .IsNotNullOrEmpty(SetorC, "SetorC", "É obrigatório o preenchimento do Setor do Corresponsavel.")
                    .IsNotNullOrEmpty(TelefoneC, "TelefoneR", "É obrigatório o preenchimento do Telefone do Corresponsavel.")
                    .IsNotNullOrEmpty(EmailC, "EmailC", "É obrigatório o preenchimento do Email do Corresponsavel.")
                    .IsNotNullOrEmpty(NomeProjeto, "NomeProjeto", "É obrigatório o preenchimento do Nome do Projeto.")
                    .IsNotNullOrEmpty(Segmento, "Segmento", "É obrigatório o preenchimento do Segmento.")
                    .IsNull(DataInicio, "DataInicio", "É obrigatório o preenchimento da Data Inicio.")
                    .IsNull(DataTermino, "DataTermino", "É obrigatório o preenchimento da Data Termino.")
                    .IsNotNullOrEmpty(Apresentacao, "Apresentacao", "É obrigatório o preenchimento da Apresentacao.")
                    .IsNotNullOrEmpty(Descricao, "Descricao", "É obrigatório o preenchimento da Descricao.")
                    .IsNotNullOrEmpty(Justificativa, "Justificativa", "É obrigatório o preenchimento da Justificativa.")
                    .IsNotNullOrEmpty(ObjetivoGeral, "ObjetivoGeral", "É obrigatório o preenchimento do Objetivo Geral.")
                    .IsNotNullOrEmpty(ObjetivoEspecifico, "ObjetivoEspecifico", "É obrigatório o preenchimento da Objetivo Especifico.")


            );
        }


        /* EF Relacionamento*/
        public CadastroClienteEntidade CadastroCliente { get; set; }
    }
}
