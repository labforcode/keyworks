using TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class ComandoAtualizacaoMaterial : ComandoMaterial
    {
        public ComandoAtualizacaoMaterial(int codigo,
                                          string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }


        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoAtualizacaoMaterial().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
