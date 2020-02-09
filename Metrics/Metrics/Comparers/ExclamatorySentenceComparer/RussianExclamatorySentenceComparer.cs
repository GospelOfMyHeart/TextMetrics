using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Metrics.Metrics.Comparers.ExclamatorySentenceComparer
{
    public class RussianExclamatorySentenceComparer : IExclamatorySentenceComparer
    {

        Regex ExclamatorySentence = new Regex(@"((([А-Я|а-я]|[0-9])+)(\s*)(([А-Я|а-я]|[0-9])*))!");
        public int CountExclamatorySentenceMatches(string text)
        {
            MatchCollection matches = ExclamatorySentence.Matches(text);
            return matches.Count;
        }
    }
}
