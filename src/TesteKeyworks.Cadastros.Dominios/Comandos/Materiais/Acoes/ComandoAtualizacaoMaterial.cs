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
            throw new NotImplementedException();
        }
    }
}
