using KABLibrary.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Logic.Parser
{
    public class ParimatchParser : IBetModelSourceParser
    {
        public IEnumerable<MatchResultBetModel> ParsePage(string htmlPage)
        {
            throw new NotImplementedException();
            // return htmlPage.Select<char, MatchResultBetModel>(_ => null);
        }
    }
}
