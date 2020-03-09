namespace Radius.Domain.Entities
{
    public class FaleConoscoEntidade : BaseEntidade
    {
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

        private void ConfigurarEmail(string email)
        {
            this.Email = email;
        }

        public string NomeEmpresa
        {
            get; private set;
        }

        private void ConfigurarNomeEmpresa(string nomeEmpresa)
        {
            this.NomeEmpresa = nomeEmpresa;
        }

        public string Assunto
        {
            get; private set;
        }

        private void ConfigurarAssunto(string assunto)
        {
            this.Assunto = assunto;
        }

        public string Mensagem
        {
            get; private set;
        }

        private void ConfigurarMensagem(string mensagem)
        {
            this.Mensagem = mensagem;
        }

        public override bool Validar()
        {
            return true;
        }
    }
}
