namespace PbStore.Domain.Pedidos.ObjetosValor
{
    public class Endereco
    {
        public Endereco(string cEP, string logradouro, string numero, string bairro, string cidade, string estado, string pais)
        {
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
    }
}
