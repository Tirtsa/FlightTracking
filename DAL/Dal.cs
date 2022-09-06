using DP;
using System.Collections.Generic;

namespace DAL
{
    public class Dal : IDAL
    {
        TrafficAdapter trafficAdapter = new TrafficAdapter();
        public List<FlightSummarize> getAllFlightsSummarize()
        {
            return trafficAdapter.GetLiveFlights();
        }

        public Flight GetFlightByKey(string key)
        {
            return trafficAdapter.GetFlightByKey(key);
        }
    }
}
