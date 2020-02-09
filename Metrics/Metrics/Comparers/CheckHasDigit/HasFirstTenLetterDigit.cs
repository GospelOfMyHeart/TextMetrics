using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Metrics.Metrics.Comparers.CheckHasDigit
{
    public class HasFirstTenLetterDigit : IStringHasDigit
    {
        Regex hasDigit = new Regex("[0-9]");
        const int count = 10;
        public bool StringHasDigit(string text)
        {
            for (int i = 0; i < Math.Clamp(count,0,text.Length); i++)
            {
                if (hasDigit.IsMatch(text[i].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
