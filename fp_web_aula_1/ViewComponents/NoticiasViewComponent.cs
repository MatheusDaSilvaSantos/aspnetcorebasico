﻿using fp_web_aula_1.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace fp_web_aula_1.ViewComponents
{
    public class NoticiasViewComponent : ViewComponent
    {
        private INoticiaService _noticiaService;

        public NoticiasViewComponent(INoticiaService noticiaService)
        {
            _noticiaService = noticiaService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int total, bool noticiasUrgentes)
        {
            var view = "noticias";

            if (noticiasUrgentes)
                view = "noticiasurgentes";

            var noticias = _noticiaService.List().Take(total);

            return View(view, noticias);
        }
    }
}
