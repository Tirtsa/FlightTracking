using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP;

namespace DAL
{
    public interface IDAL
    {
        List<FlightSummarize> getAllFlightsSummarize();
        Flight GetFlightByKey(string key);

        string getEvent(DateTime start, DateTime end);
        //Weather getWeather(Location location)();
        //HebEvent getHebevent(Date date)();
    }
}
