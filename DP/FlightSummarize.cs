using System;
using Microsoft.Maps.MapControl.WPF;


namespace DP
{
    public class FlightSummarize
    {
        public string Id { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public int Speed { get; set; }
        public string AircraftModelCode { get; set; }
        public string Registration { get; set; }
        public DateTime DateTime { get; set; }
        public string OriginAirportIATA { get; set; }
        public string DestinationAirportIATA { get; set; }
        public string AbrFlightCode { get; set; }
        public string FullFlightCode { get; set; }
        public string AirlineICAO { get; set; }
        public Location Location { get { return new Location(Lat, Long); } }
    }
}
