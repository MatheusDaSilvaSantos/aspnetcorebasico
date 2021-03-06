﻿using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace fp_web_aula_1
{
    public class MeuMiddleware
    {
        private readonly ILoggerApi _loggerApi;
        private readonly RequestDelegate _next;
        private Stopwatch inicio { get; set; }

        public MeuMiddleware(RequestDelegate next)
        {
            _loggerApi = new LoggerApi();
            _next = next;
        }
        
        public async Task Invoke(HttpContext httpContext)
        {
            inicio = Stopwatch.StartNew();
            inicio.Start();
            await _next(httpContext);
            inicio.Stop();
            var final = inicio.ElapsedMilliseconds;
            _loggerApi.Log(httpContext, final);
        }
    }
}
