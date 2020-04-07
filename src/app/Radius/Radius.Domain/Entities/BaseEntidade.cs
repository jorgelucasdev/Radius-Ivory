using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Radius.Domain.Entities
{
    public abstract class BaseEntidade : Notifiable, IValidatable
    {
        [Key]
        public Guid Id
        {
            get; private set;
        }

        public DateTime DataCriacao
        {
            get; private set;
        }

        public DateTime? DataAtualizacao
        {
            get; private set;
        }

        public bool EstaAtivo
        {
            get; private set;
        }

        public void Deletar() { this.EstaAtivo = false; }
        public void Ativar() { this.EstaAtivo = true; }
        public void GerarId() { this.Id = Guid.NewGuid(); }
        public void PrepararParaInserir()
        {
            Ativar();
            GerarId();
            ConfigurarDataCriacao();
        }
        public void ConfigurarDataCriacao()
        {
            this.DataCriacao = DateTime.UtcNow;
        }
        public void PrepararParaAtualizar()
        {
            this.DataAtualizacao = DateTime.UtcNow;
        }

        public static bool VerificaGuidValido(Guid guidrecebido)
        {
            Guid guidvalido;
            string guid = guidrecebido.ToString();
            return Guid.TryParse(guid, out guidvalido);
        }


        public abstract void Validate();
        
    }
}
