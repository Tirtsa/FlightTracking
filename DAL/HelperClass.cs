using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HelperClass
    {
        public DateTime EpochToDateTime(double TimeStamp)
        {
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            start = start.AddSeconds(TimeStamp);
            return start;
        }
    }
}
