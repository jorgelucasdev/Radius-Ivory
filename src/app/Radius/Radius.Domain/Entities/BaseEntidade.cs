using System;
using System.ComponentModel.DataAnnotations;

namespace Radius.Domain.Entities
{
    public abstract class BaseEntidade
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

        public abstract bool Validar();
    }
}
