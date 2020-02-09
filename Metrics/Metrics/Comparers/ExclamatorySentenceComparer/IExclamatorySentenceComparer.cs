using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Comparers.ExclamatorySentenceComparer
{
    public interface IExclamatorySentenceComparer
    {
        int CountExclamatorySentenceMatches(string text);
    }
}
