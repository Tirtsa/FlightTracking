using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP;
using Newtonsoft.Json;

namespace DAL
{
    class CalendarAdapter
    {
        private const string oneDateURLStart = @"https://www.hebcal.com/converter?cfg=json&date=";
        private const string oneDateURLEnd = @"&g2h=1&strict=1";
        private WebAdapter webAdapter = new WebAdapter();

        public Calendar getCalendar(DateTime start, DateTime end)
        {
            Calendar calendar = new Calendar();
            for(DateTime date = start; date <= end; date.AddDays(1))
            {
                var json = webAdapter.GetDataFromUrl(oneDateURLStart + date.ToString("yyyy-MM-dd") + oneDateURLEnd);
                calendar.days.Add((HebDate)JsonConvert.DeserializeObject(json, typeof(HebDate)));
            }
            return calendar;
        }
        



    }
}
