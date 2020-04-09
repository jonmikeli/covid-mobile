using Newtonsoft.Json.Linq;

namespace IoTSolution.API.API.DataContracts.IoT
{
    public class Properties
    {
        public JObject Desired { get; set; }

        public JObject Reported { get; set; }
    }
}
