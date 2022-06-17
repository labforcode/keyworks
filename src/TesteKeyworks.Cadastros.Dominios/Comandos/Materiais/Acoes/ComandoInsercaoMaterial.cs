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
            throw new NotImplementedException();
        }
    }
}
