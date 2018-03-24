using System.Collections.Generic;

namespace fp_web_aula_1.Controllers
{
    public interface INoticiaService
    {
        IEnumerable<Noticia> List();
    }
}