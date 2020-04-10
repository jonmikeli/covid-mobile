using System;
using System.ComponentModel.DataAnnotations;

namespace IoTSolution.API.API.DataContracts.IoT
{
    public class Tags
    {
        #region System and manufacturer oriented
        [Required]
        public string DeviceType { get; set; }

        public string SerialNumber { get; set; }

        public string ManufacturerCode { get; set; }

        [Required]
        public string FirmwareVersion { get; set; }

        public DateTime? LastFirmwareUpdate { get; set; }
        #endregion

        #region Message and settings oriented
        [Required]
        public string DataSchema { get; set; }
        [Required]
        public string DataSchemaVersion { get; set; }
        #endregion

        #region Business oriented      
        [Required]
        public string Environment { get; set; }

        public string Status { get; set; }

        public Location Location { get; set; }
        #endregion
    }
}
