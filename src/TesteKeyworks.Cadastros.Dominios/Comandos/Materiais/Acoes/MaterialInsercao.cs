namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class MaterialInsercao : MaterialComando
    {
        public MaterialInsercao(int codigo,
                                string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
