using System;
using FluentValidator;

namespace PbStore.Domain.Pedidos
{
    public abstract class Entidade : Notifiable
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
