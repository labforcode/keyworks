using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
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
                                  Responsavel responsavel,
                                  Telefone telefone,
                                  List<Material> materiais)
        {
            Codigo = codigo;
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
            ValidationResult = new ValidacaoComandoAtualizacaoCliente().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
