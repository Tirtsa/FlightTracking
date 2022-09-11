using DP;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class Dal : IDAL
    {
        TrafficAdapter trafficAdapter = new TrafficAdapter();
        CalendarAdapter calendarAdapter = new CalendarAdapter();

        public List<FlightSummarize> getAllFlightsSummarize()
        {
            return trafficAdapter.GetLiveFlights();
        }

        public Flight GetFlightByKey(string key)
        {
            return trafficAdapter.GetFlightByKey(key);
        }

        public Calendar getCalendar(DateTime start, DateTime end)
        {
            return calendarAdapter.getCalendar(start, end);
        }

        public string getEvent(DateTime start, DateTime end)
        {
            Calendar calendar = getCalendar(start, end);

            if (calendar.days != null)
            {
                foreach (HebDate day in calendar.days)
                    if (!day.events[0].StartsWith("Parashat") && !day.events[0].StartsWith("Erev"))
                        return day.events[0];
            }
            return null;
        }
    }
}
