using TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class ComandoInsercaoMaterial : ComandoMaterial
    {
        public ComandoInsercaoMaterial(int codigo,
                                string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoInsercaoMaterial().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
