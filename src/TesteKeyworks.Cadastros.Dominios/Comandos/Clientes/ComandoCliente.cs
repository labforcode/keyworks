using TesteKeyworks.Cadastros.Dominios.Core.Comandos;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes
{
    public abstract class ComandoCliente : Comando
    {
        public int Codigo { get; protected set; }

        public string Cnpj { get; protected set; }

        public string RazaoSocial { get; protected set; }

        public bool Ativo { get; protected set; }

        public int PlantaId { get; protected set; }

        public int TipoCliente { get; protected set; }

        public Responsavel Responsavel { get; protected set; }

        public Telefone Telefone { get; protected set; }

        public List<Material> Materiais { get; protected set; }
    }
}
