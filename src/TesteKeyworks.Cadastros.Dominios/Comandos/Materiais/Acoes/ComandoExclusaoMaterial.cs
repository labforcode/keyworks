using TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class ComandoExclusaoMaterial : ComandoMaterial
    {
        public ComandoExclusaoMaterial(int codigo)
        {
            Codigo = codigo;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoExclusaoMaterial().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
