using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Metrics.Metrics.Comparers.CapitalLetterComparer
{
    public class RussianCapitalLetterMatcher : ICapitalLetterComparer
    {
        Regex capitalLetter = new Regex("[А-Я]");
        public int CountCapitalLettersMatches(string text)
        {
            MatchCollection matches = capitalLetter.Matches(text);
            return matches.Count;
        }
    }
}
