using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class TrafficAdapter
    {
        private const string AllFlightsURL = @"https://data-cloud.flightradar24.com/zones/fcgi/feed.js?faa=1&satellite=1&mlat=1&flarm=1&adsb=1&gnd=1&air=1&vehicles=1&estimated=1&maxage=14400&gliders=1&airport=TLV&stats=1";
        private const string OneFlightURL = @"https://data-live.flightradar24.com/clickhandler/?version=1.5&flight=";

        public List<FlightSummarize> GetLiveFlights()
        {
            List<FlightSummarize> AllFlights = new List<FlightSummarize>();
            JObject allFlightsData;

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(AllFlightsURL);
                HelperClass helper = new HelperClass();
                allFlightsData = JObject.Parse(json);
                try
                {
                    foreach (var item in allFlightsData)
                    {
                        var key = item.Key;
                        if (key != "full_count" && key != "version")
                            AllFlights.Add(new FlightSummarize
                            {
                                Id = key,
                                Lat = Convert.ToDouble(item.Value[1]),
                                Long = Convert.ToDouble(item.Value[2]),
                                Speed = (int)item.Value[5],
                                AircraftModelCode = item.Value[8].ToString(),
                                Registration = item.Value[9].ToString(),
                                DateTime = helper.EpochToDateTime(Convert.ToDouble(item.Value[10])),
                                OriginAirportIATA = item.Value[11].ToString(),
                                DestinationAirportIATA = item.Value[12].ToString(),
                                AbrFlightCode = item.Value[13].ToString(),
                                FullFlightCode = item.Value[16].ToString(),
                                AirlineICAO = item.Value[17].ToString()
                            });
                    }
                }
                catch (Exception e)
                {
                    Debug.Print(e.Message);
                }
            }
            return AllFlights;
        }

        public Flight GetFlightByKey(string key)
        {
            Flight myDeserializedFlight = new Flight();
            using (var webClient = new System.Net.WebClient())
            {
                try
                {
                    var json = webClient.DownloadString(OneFlightURL + key);
                    try
                    {
                        myDeserializedFlight = (Flight)JsonConvert.DeserializeObject(json, typeof(Flight));
                    }
                    catch (Exception e)
                    {
                        Debug.Print(e.Message);
                    }
                }
                catch (Exception e)
                {
                    Debug.Print(e.Message);
                }

            }
            return myDeserializedFlight;
        }
    }
}
