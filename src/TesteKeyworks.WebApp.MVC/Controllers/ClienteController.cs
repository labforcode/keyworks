using Microsoft.AspNetCore.Mvc;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Clientes;

namespace TesteKeyworks.WebApp.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clientes = _clienteServico.ObterClientesAsync().Result;
            ViewData["Clientes"] = clientes;

            return View();
        }

        [HttpGet]
        public IActionResult PesquisarCliente(string pCodigo)
        {

            if (string.IsNullOrEmpty(pCodigo)) return Ok();

            var codigo = Convert.ToInt32(pCodigo);
            var cliente = _clienteServico.ObterClienteAsync(codigo).Result;
            var clientes = new List<ClienteViewModel>
            {
                cliente
            };

            ViewData["Clientes"] = clientes;

            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult CadastrarCliente([FromBody] ClienteDto cliente)
        {
            _clienteServico.Adicionar(cliente);

            return Ok();
        }

        [HttpPost]
        public IActionResult AtualizarCliente([FromBody] ClienteDto cliente)
        {


            return Ok();
        }

        [HttpDelete]
        public IActionResult ExcluirCliente(int codigo)
        {
            var cliente = new ClienteDto { Codigo = codigo };
            _clienteServico.Excluir(cliente);

            return Ok();
        }
    }
}
