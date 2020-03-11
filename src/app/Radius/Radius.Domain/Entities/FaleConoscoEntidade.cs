using Flunt.Notifications;
using Flunt.Validations;

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

        public override void Validate()
        {
            AddNotifications(
                     new Contract()
                    .IsNotNullOrEmpty(Mensagem, "Corpo", "O corpo da mensagem é obrigatório.")
                    .IsNotNullOrEmpty(Assunto, "Assunto", "O assunto da mensagem e obrigatório")
                    .IsNotNullOrEmpty(Email, "Email", "O email do usuario é obrigatório.")
                    .IsNotNullOrEmpty(Nome, "Nome", "O nome do usuario e obrigatório")

            );
        }
    }
}
