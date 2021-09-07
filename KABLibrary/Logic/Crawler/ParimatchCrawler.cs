using KABLibrary.Logic.Parser;
using KABLibrary.Logic.RequestHandler;
using KABLibrary.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Logic.Crawler
{
    class ParimatchCrawler : IBetsSourceCrawler
    {
        private readonly IRequestHandler _requestHandler;
        private readonly IBetModelSourceParser _parser;

        public async Task<IEnumerable<MatchResultBetModel>> GetTodaysMatchResultBets() => 
            await Task.Run(Perform);

        public ParimatchCrawler(IRequestHandler hanlder, IBetModelSourceParser parser)
        {
            _requestHandler = hanlder;
            _parser = parser;
        }

        private IEnumerable<MatchResultBetModel> Perform()
        {
            var pageHtml = _requestHandler.GetHTMLString(Constants.Constants.PM_TODAY_PAGE_URL).Result;
            return _parser.ParsePage(pageHtml);
        }
    }
}
