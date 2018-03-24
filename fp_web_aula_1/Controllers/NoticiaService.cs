using System.Collections.Generic;

namespace fp_web_aula_1.Controllers
{
    public class NoticiaService : INoticiaService
    {
        private ILoggerApi _log;

        public NoticiaService(ILoggerApi logerApi)
        {
            _log = logerApi;
        }
        public IEnumerable<Noticia> List()
        {
            _log.Log(null, 2);
            for (int i = 0; i < 10; i++)
                yield return new Noticia() {Id = i, Titulo = $"Notícia sobre {i}" };
        }
    }
}
