using Microsoft.AspNetCore.Mvc;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.DTOs.Materiais;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;

namespace TesteKeyworks.WebApp.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        public IActionResult Index()
        {
            var cliente = new ClienteDto
            {
                Cnpj = "12345678901234",
                RazaoSocial = "Teste",
                PlantaId = 1,
                TipoCliente = 1,
                Responsavel = new ResponsavelDto { Email = "teste@teste.com.br", Nome = "Cadastro Teste" },
                Telefone = new TelefoneDto { DDI = "55", DDD = "43", Numero = "988106324" },
                Materiais = new List<MaterialDto> { new MaterialDto { Codigo = 1, Descricao = "Teste" } }
            };

            _clienteServico.Adicionar(cliente);

            return View();
        }
    }
}
