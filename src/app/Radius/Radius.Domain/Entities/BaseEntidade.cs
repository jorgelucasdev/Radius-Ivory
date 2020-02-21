using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Radius.Domain.Entities
{
    public abstract class BaseEntidade
    {
        [Key]
        public Guid Id { get; set; }
        private DateTime? _dataCriacao;

        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }

        public bool eAtivo { get; set; }

        public void Deletar() { this.eAtivo = false; }
        public void Ativar() { this.eAtivo = true; }
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
        public void ConfigureUpdateAt()
        {
            this.UpdateAt = DateTime.UtcNow;
        }
    }
}
