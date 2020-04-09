using System.ComponentModel.DataAnnotations;

namespace IoTSolution.API.API.DataContracts.IoT.Requests
{
    public class ProvisionDeviceRequest
    {
        [Required]
        public string DeviceId { get; set; }

        public DeviceIoTSettings DeviceIoTSettings { get; set; }
    }
}
