using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Comparers.CapitalLetterComparer
{
    public interface ICapitalLetterComparer
    {
        int CountCapitalLettersMatches(string text);
    }
}
