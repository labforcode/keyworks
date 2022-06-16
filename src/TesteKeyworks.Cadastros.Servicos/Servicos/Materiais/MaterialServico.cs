using TesteKeyworks.Cadastros.Servicos.Interfaces.Materiais;

namespace TesteKeyworks.Cadastros.Servicos.Servicos.Materiais
{
    public class MaterialServico : IMaterialServico
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
