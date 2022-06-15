using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;

namespace TesteKeyworks.Cadastros.Dominios.Entidades.Clientes
{
    public class Cliente
    {
        public Cliente(int codigo,
                       string cnpj,
                       string razaoSocial,
                       bool ativo,
                       int plantaId,
                       int tipoCliente,
                       Responsavel responsavel,
                       Telefone telefone,
                       List<Material> materiais)
        {
            Codigo = codigo;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            TipoCliente = tipoCliente;
            Responsavel = responsavel;
            Telefone = telefone;
            _materiais = materiais;
        }

        protected Cliente() { }

        public int Codigo { get; private set; }

        public string Cnpj { get; private set; }

        public string RazaoSocial { get; private set; }

        public bool Ativo { get; private set; }

        public int PlantaId { get; private set; }

        public int TipoCliente { get; private set; }

        public Responsavel Responsavel { get; private set; }

        public Telefone Telefone { get; private set; }

        private List<Material> _materiais { get; set; }

        public virtual ICollection<Material> Materiais { get; set; }

        public void AdicionarMaterial(Material material)
        {
            // retornar um domain exception
            if (_materiais.Exists(w => w.Codigo == material.Codigo) == false) return;

            _materiais.Add(material);
        }

        public void RemoverMaterial(Material material)
        {
            // retornar um domain exception
            if (_materiais.Exists(w => w.Codigo == material.Codigo) == false) return;

            _materiais.Remove(material);
        }

        public void AtualizarMaterial(Material material)
        {
            // retornar um domain exception
            if (_materiais.Exists(w => w.Codigo == material.Codigo) == false) return;

            var mtr = _materiais.FirstOrDefault(w => w.Codigo == material.Codigo);
            if(mtr != null) _materiais.Remove(mtr);

            _materiais.Add(material);
        }

        public void AdicionarResponsavel(Responsavel responsavel)
        {

        }

        public void AtualizarResponsavel(Responsavel responsavel)
        {

        }

        public void AdicionarTelefone(Telefone telefone)
        {

        }

        public void AtualizarTelefone(Telefone telefone)
        {

        }
    }
}
