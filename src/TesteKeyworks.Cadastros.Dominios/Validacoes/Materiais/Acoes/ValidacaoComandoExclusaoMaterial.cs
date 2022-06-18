using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais.Acoes
{
    public class ValidacaoComandoExclusaoMaterial : ValidacaoComandoMaterial<ComandoExclusaoMaterial>
    {
        public ValidacaoComandoExclusaoMaterial()
        {
            ValidarCodigo();
        }
    }
}
