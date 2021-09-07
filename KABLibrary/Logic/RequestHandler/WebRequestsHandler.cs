using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Extreme.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KABLibrary.Logic.RequestHandler
{
    public class WebRequestsHandler : IRequestHandler
    {
        private readonly HttpClient _client;

        public WebRequestsHandler(HttpClient client) => 
            _client = client;

        public async Task<string> GetHTMLString(string url) =>
            await _client.GetStringAsync(url);
    }
}
