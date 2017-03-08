using System;

namespace PbStore.Domain.Pedidos.ObjetosValor
{
    public class CPF
    {
        public CPF(string numero)
        {
            Numero = numero;

            if(Numero.Length != 11)
                throw new Exception("CPF inválido");
        }

        public string Numero { get; private set; }
    }
}
