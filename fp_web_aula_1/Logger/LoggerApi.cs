using Microsoft.AspNetCore.Http;
using System;

namespace fp_web_aula_1
{
    public class LoggerApi : ILoggerApi
    {
        private Guid guid;

        public LoggerApi()
        {
            guid = Guid.NewGuid();
        }

        public void Log(HttpContext context, long totalTime)
        {
            
        }
    }
}
