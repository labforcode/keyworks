using TesteKeyworks.Cadastros.Servicos.DTOs.Materiais;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Materiais;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Materiais;

namespace TesteKeyworks.Cadastros.Servicos.Servicos.Materiais
{
    public class MaterialServico : IMaterialServico
    {
        public void Adicionar(MaterialDto material)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(MaterialDto material)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialViewModel> ObterMaterial(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MaterialViewModel>> ObterMateriais()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
