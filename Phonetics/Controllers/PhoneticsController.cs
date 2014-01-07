using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Phonetics.Controllers
{
    public class PhoneticsController : ApiController
    {
        public IEnumerable<string> Get(int number)
        {
            var suggestions = new List<string>();
            suggestions.Add("dog");
            suggestions.Add("cat");
            return suggestions;
        }
    }
}