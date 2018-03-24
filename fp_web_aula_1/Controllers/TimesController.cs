using fp_web_aula_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace fp_web_aula_1.Controllers
{
    public class TimesController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(Time time)
        {
            if (!ModelState.IsValid)
                return View(time);
            return View();
        }
    }
}