namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class MaterialAtualizacao : MaterialComando
    {
        public MaterialAtualizacao(int codigo,
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
