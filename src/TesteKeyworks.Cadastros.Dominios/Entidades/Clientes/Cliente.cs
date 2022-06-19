namespace TesteKeyworks.Cadastros.Dominios.Entidades.Clientes
{
    public class Cliente
    {
        public Cliente(int codigo,
                       string cnpj,
                       string razaoSocial,
                       bool ativo,
                       int plantaId,
                       int tipoCliente,
                       int codigoMaterial,
                       string responsavelNome,
                       string responsavelEmail,
                       string ddi,
                       string ddd,
                       string telefone)
        {
            Codigo = codigo;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            TipoCliente = tipoCliente;
            CodigoMaterial = codigoMaterial;
            ResponsavelNome = responsavelNome;
            ResponsavelEmail = responsavelEmail;
            DDI = ddi;
            DDD = ddd;
            Telefone = telefone;
        }

        protected Cliente() { }

        public int Codigo { get; private set; }

        public string Cnpj { get; private set; }

        public string RazaoSocial { get; private set; }

        public bool Ativo { get; private set; }

        public int PlantaId { get; private set; }

        public int TipoCliente { get; private set; }

        public int CodigoMaterial { get; private set; }

        public string ResponsavelNome { get; private set; }

        public string ResponsavelEmail { get; private set; }

        public string DDI { get; private set; }

        public string DDD { get; private set; }

        public string Telefone { get; private set; }
    }
}
