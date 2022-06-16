namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class MaterialExclusao : MaterialComando
    {
        public MaterialExclusao(int codigo)
        {
            Codigo = codigo;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
