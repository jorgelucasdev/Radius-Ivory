using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Domain.Entities
{
    public class FaleConoscoEntidade : BaseEntidade
    {
        public string Nome
        {
            get { return this.Nome; }
            set { ConfigurarNome(value); }
        }

        private void ConfigurarNome(string nome)
        {
            this.Nome = nome;
        }

        public string Email
        {
            get { return this.Email; }
            set { ConfigurarEmail(value); }
        }

        private void ConfigurarEmail(string email)
        {
            this.Email = email;
        }

        public string NomeEmpresa
        {
            get { return this.Nome; }
            set { ConfigurarNomeEmpresa(value); }
        }

        private void ConfigurarNomeEmpresa(string nomeEmpresa)
        {
            this.NomeEmpresa = nomeEmpresa;
        }

        public string Assunto
        {
            get { return this.Assunto; }
            set { ConfigurarAssunto(value); }
        }

        private void ConfigurarAssunto(string assunto)
        {
            this.Assunto = assunto;
        }

        public string Mensagem
        {
            get { return this.Mensagem; }
            set { ConfigurarMensagem(value); }
        }

        private void ConfigurarMensagem(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}
