using FluentValidator;

namespace PbStore.Domain.Pedidos.ObjetosValor
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new ValidationContract<Email>(this)
                .IsEmail(x => x.Endereco, "E-mail inválido");
        }
        
        public string Endereco { get; private set; }
    }
}
