using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(NotasModel notas)
        {
            ModelState.Clear();
            if (validate(notas))
            {
                notas.CalcularMedia();
                
            }
            return View("Index", notas);
        }

        private bool validate(NotasModel notas) {
            bool valid = true;
            if (notas.Nota1 == null) {
                ModelState.AddModelError("Nota1", "Informe um valor numérico");
                valid = false;
            }

            if(notas.Nota1 < 0 || notas.Nota1 > 10)
            {
                ModelState.AddModelError("Nota1", "O valor deve estar compreendido entre 0 e 10");
                valid = false;
            }

            if (notas.Nota2 == null)
            {
                ModelState.AddModelError("Nota2", "Informe um valor numérico");
                valid = false;
            }

            if (notas.Nota1 < 0 || notas.Nota1 > 10)
            {
                ModelState.AddModelError("Nota2", "O valor deve estar compreendido entre 0 e 10");
                valid = false;
            }

            return valid;
        }
    }
}
