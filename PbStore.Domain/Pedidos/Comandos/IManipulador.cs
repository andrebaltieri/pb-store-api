namespace PbStore.Domain.Pedidos.Comandos
{
    public interface IManipulador<in T> where T : IComando
    {
        void Manipular(T comando);
    }
}
