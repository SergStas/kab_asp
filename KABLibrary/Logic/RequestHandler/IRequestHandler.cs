using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Logic.RequestHandler
{
    public interface IRequestHandler
    {
        Task<string> GetHTMLString(string url);
    }
}
