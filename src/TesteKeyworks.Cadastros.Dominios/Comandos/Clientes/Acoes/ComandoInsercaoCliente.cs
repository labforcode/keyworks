using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ComandoInsercaoCliente : ComandoCliente
    {
        public ComandoInsercaoCliente(int codigo,
                               string cnpj,
                               string razaoSocial,
                               bool ativo,
                               int plantaId,
                               int tipoCliente,
                               Responsavel responsavel,
                               Telefone telefone,
                               List<Material> materiais)
        {
            Codigo = codigo;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            Responsavel = responsavel;
            TipoCliente = tipoCliente;
            Telefone = telefone;
            Materiais = materiais;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
