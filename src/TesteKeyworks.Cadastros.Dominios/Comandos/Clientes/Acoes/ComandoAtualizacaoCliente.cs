using TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ComandoAtualizacaoCliente : ComandoCliente
    {
        public ComandoAtualizacaoCliente(int codigo,
                                  string razaoSocial,
                                  bool ativo,
                                  int plantaId,
                                  int tipoCliente,
                                  int codigoMaterial,
                                  Responsavel responsavel,
                                  Telefone telefone)
        {
            Codigo = codigo;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            Responsavel = responsavel;
            TipoCliente = tipoCliente;
            CodigoMaterial = codigoMaterial;
            Telefone = telefone;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoAtualizacaoCliente().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
