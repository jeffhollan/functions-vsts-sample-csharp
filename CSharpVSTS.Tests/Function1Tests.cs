using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using Xunit;

namespace CSharpVSTS.Tests
{
    public class Function1Test
    {
        [Fact]
        public void CallHttp()
        {
            HttpContext context = new DefaultHttpContext();
            HttpRequest request = new DefaultHttpRequest(context)
            {
                Method = "GET",
                Body = null
            };

            ILogger nullLogger = new NullLogger<string>();
            var response = Function1.Run(request, nullLogger) as OkObjectResult;

            Assert.NotNull(response);
            Assert.Equal(200, response.StatusCode);
        }
    }
}
