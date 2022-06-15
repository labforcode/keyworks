namespace TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones
{
    public class Telefone
    {
        public Telefone(string ddi,
                        string ddd,
                        string numero)
        {
            DDI = ddi;
            DDD = ddd;
            Numero = numero;
        }

        public string DDI { get; private set; }

        public string DDD { get; private set; }

        public string Numero { get; private set; }
    }
}
