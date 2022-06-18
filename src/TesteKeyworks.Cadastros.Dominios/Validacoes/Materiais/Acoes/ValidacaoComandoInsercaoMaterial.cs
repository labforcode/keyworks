using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais.Acoes
{
    public class ValidacaoComandoInsercaoMaterial : ValidacaoComandoMaterial<ComandoInsercaoMaterial>
    {
        public ValidacaoComandoInsercaoMaterial()
        {
            ValidarDescricao();
        }
    }
}
