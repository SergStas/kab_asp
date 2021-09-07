using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KABLibrary.Models.DBModels;

namespace KABLibrary.Logic.Crawler
{
    public interface IBetsSourceCrawler
    {
        public Task<IEnumerable<MatchResultBetModel>> GetTodaysMatchResultBets();
    }
}
