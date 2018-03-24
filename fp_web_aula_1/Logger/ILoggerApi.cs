using Microsoft.AspNetCore.Http;

namespace fp_web_aula_1
{
    public interface ILoggerApi
    {
        void Log(HttpContext context, long totalTime);
    }
}