namespace TesteKeyworks.Cadastros.Dominios.Entidades.Clientes
{
    public class Cliente
    {
        public Cliente(int codigo,
                       string cnpj,
                       string razaoSocial,
                       bool ativo,
                       int plantaId,
                       int tipoCliente)
        {
            Codigo = codigo;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            TipoCliente = tipoCliente;
        }

        protected Cliente() { }

        public int Codigo { get; private set; }

        public string Cnpj { get; private set; }

        public string RazaoSocial { get; private set; }

        public bool Ativo { get; private set; }

        public int PlantaId { get; private set; }

        public int TipoCliente { get; private set; }

    }
}
