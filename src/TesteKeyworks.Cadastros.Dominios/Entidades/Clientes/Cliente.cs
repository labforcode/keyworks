using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;

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
                       Responsavel responsavel,
                       Telefone telefone)
        {
            Codigo = codigo;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            TipoCliente = tipoCliente;
            CodigoMaterial = codigoMaterial;
            Responsavel = responsavel;
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

        public Responsavel Responsavel { get; private set; }

        public Telefone Telefone { get; private set; }
    }
}
