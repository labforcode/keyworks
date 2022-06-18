using TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes;
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
                               int codigoMaterial,
                               Responsavel responsavel,
                               Telefone telefone)
        {
            Codigo = codigo;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            CodigoMaterial = codigoMaterial;
            Responsavel = responsavel;
            TipoCliente = tipoCliente;
            Telefone = telefone;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoInsercaoCliente().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
