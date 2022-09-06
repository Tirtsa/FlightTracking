using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;


namespace DP
{
    public class FlightVisibleInfo
    {
        public string Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Location Location { get { return new Location(Latitude, Longitude); } }
        public string AbrFlightCode { get; set; }
        public string FullFlightCode { get; set; }
        public string AirlineName { get; set; }
        public string OriginAirportIATA { get; set; }
        public string OriginAirportCity { get; set; }
        public string DestinationAirportIATA { get; set; }
        public string DestinationAirportCity { get; set; }
        public DateTime ScheduledDeparture { get; set; }
        public DateTime? RealDeparture { get; set; } = null;
        public DateTime ScheduledArrival { get; set; }
        public DateTime? EstimatedArrival { get; set; } = null;
        public string ImgUrl { get; set; }
    }
}
