namespace TesteKeyworks.Cadastros.Servicos.ViewModels.Clientes
{
    public class ClienteViewModel
    {
        public int Codigo { get; set; }

        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public bool Ativo { get; set; }

        public int PlantaId { get; set; }

        public int TipoCliente { get; set; }

        public int CodigoMaterial { get; set; }

        public string ResponsavelNome { get; set; }

        public string ResponsavelEmail { get; set; }

        public string DDI { get; set; }

        public string Telefone { get; set; }
    }
}
