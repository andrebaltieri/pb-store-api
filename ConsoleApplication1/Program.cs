using System;
using PbStore.Domain.Pedidos.Comandos;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            GerarPedido(new RegistrarPedido { });

            Console.WriteLine();
            Console.Read();
        }

        static void GerarPedido(RegistrarPedido comando)
        {
            //var manipulador = new ManipuladorPedidos();
            //manipulador.Manipular(comando);
        }
    }
}
