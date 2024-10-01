using CadastroCliente.Data;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
{
    public class ClientesController : Controller
    {
        private readonly AppCont _appCont;

        public ClientesController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allClientes= _appCont.Clientes.ToList();
            return View(allClientes);
        }
    }
}
