namespace TesteKeyworks.Cadastros.Servicos.DTOs.Clientes
{
    public class ClienteDto
    {
        public int Codigo { get; set; }

        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public bool Ativo { get; set; }

        public int PlantaId { get; set; }

        public int TipoCliente { get; set; }

        public int CodigoMaterial { get; set; }

        public ResponsavelDto Responsavel { get; set; }

        public TelefoneDto Telefone { get; set; }
    }
}
