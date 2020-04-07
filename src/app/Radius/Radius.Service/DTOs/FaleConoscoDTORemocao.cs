using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Service.DTOs
{
    public class FaleConoscoDTORemocao : Notifiable, IValidatable
    {
        public Guid Id { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                      .AreNotEquals(Id, Guid.Parse("00000000-0000-0000-0000-000000000000"), "Id", "Id e obrigatorio")
                  );
        }
    }
}
