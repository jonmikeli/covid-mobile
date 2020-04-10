using System.ComponentModel.DataAnnotations;

namespace IoTSolution.API.API.DataContracts.IoT.Requests
{
    public class ProvisionDeviceWithTagsRequest
    {
        [Required]
        public string DeviceId { get; set; }

        [Required]
        public Tags Tags { get; set; }
    }
}
