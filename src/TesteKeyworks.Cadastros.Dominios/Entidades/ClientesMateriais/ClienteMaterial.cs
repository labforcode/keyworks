using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;

namespace TesteKeyworks.Cadastros.Dominios.Entidades.ClientesMateriais
{
    public class ClienteMaterial
    {
        protected ClienteMaterial()
        {
        }

        public int CodigoCliente { get; private set; }

        public int CodigoMaterial { get; private set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Material Material { get; set; }
    }
}
