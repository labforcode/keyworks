using TesteKeyworks.Cadastros.Dominios.Core.Notificacoes;
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

        public void AdicionarMaterial(Material material)
        {
            if (_materiais.Exists(w => w.Codigo == material.Codigo)) Notificacao.RegistrarNotificacao($"{material.Descricao} já vinculado ao cliente, verifique!");

            _materiais.Add(material);
        }

        public void RemoverMaterial(Material material)
        {
            if (_materiais.Exists(w => w.Codigo == material.Codigo) == false) Notificacao.RegistrarNotificacao($"{material.Descricao} não está vinculado ao cliente, verifique!");

            _materiais.Remove(material);
        }

        public void AtualizarMaterial(Material material)
        {
            if (_materiais.Exists(w => w.Codigo == material.Codigo) == false) Notificacao.RegistrarNotificacao($"{material.Descricao} não está vinculado ao cliente, verifique!");

            var mtr = _materiais.FirstOrDefault(w => w.Codigo == material.Codigo);
            if (mtr != null) _materiais.Remove(mtr);

            _materiais.Add(material);
        }
    }
}
