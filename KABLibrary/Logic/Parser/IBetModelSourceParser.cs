using KABLibrary.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Logic.Parser
{
    public interface IBetModelSourceParser
    {
        IEnumerable<MatchResultBetModel> ParsePage(string htmlPage);
    }
}
