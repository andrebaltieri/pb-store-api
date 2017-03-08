namespace PbStore.Domain.Pedidos.ObjetosValor
{
    public class Nome
    {
        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {SegundoNome}";
        }
    }
}
