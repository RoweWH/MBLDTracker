using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLDTracker
{
    public static class FormattingTools
    {
        public static string FormatTime(string time)
        {
            if (TimeSpan.Parse(time) < new TimeSpan(1, 0, 0))
            {
                time = time.Substring(3, time.Length - 3);
                return time.TrimStart(new char[] { '0' });
            }
            else
            {
                return time.TrimStart(new char[] { '0' });
            }
        }
    }
}
