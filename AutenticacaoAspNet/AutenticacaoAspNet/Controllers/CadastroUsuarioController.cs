using AutenticacaoAspNet.Filters;
using AutenticacaoAspNet.Models;
using System.Web.Mvc;

namespace AutenticacaoAspNet.Controllers
{
    public class CadastroUsuarioController : Controller
    {
        // GET: CadastroUsuario
        [AutorizacaoTipo(new[] { TipoUsuario.Administrador }) ]
        public ActionResult Index()
        {
            return View();
        }
    }
}