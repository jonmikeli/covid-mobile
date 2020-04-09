using Newtonsoft.Json;

namespace IoTSolution.API.Services.Model.IoT
{
    public class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
