using Newtonsoft.Json.Linq;
using System;


namespace IoTSolution.API.API.DataContracts.IoT
{
    public class Schema
    {
        public string Type { get; set; }

        public string Version { get; set; }

        public JObject Content { get; set; }

        public string DeviceType { get; set; }

        public DateTime CreationDate { get; set; }

        public string Id { get; set; }
    }
}
