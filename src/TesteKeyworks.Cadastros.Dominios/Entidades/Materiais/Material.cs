using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;

namespace TesteKeyworks.Cadastros.Dominios.Entidades.Materiais
{
    public class Material
    {
        public Material(int codigo,
                        string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Codigo { get; private set; }

        public string Descricao { get; private set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
