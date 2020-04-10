using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

using IoTSolution.API.Services.Model.IoT;

using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json.Linq;

namespace IoTSolution.API.Services.Contracts
{
    public interface IDeviceManagementService
    {
        Task<string> GetPrimaryKeyOrThumbprintFromDeviceAsync(string deviceId);
        Task<string> GetSecondaryKeyOrThumbprintFromDeviceAsync(string deviceId);
        Task<Device> GetDeviceAsync(string deviceId);
        Task<Device> AddDeviceAsync(string deviceId);
        Task<Device> AddDeviceAsync(string deviceId, Model.IoT.DeviceIoTSettings options);
        Task<bool> RemoveDeviceAsync(string deviceId);
        Task<Device> DisableDeviceAsync(string deviceId);
        Task<Device> EnableDeviceAsync(string deviceId);

        Task<bool> UpdateDeviceSettings(string deviceId, Model.IoT.DeviceIoTSettings options);

        Task<JArray> GetDevicesAsync(int maxCount);
        Task<JArray> GetDevicesAsync(string query, int maxCount);



        Task<Device> AddDeviceWithTagsAsync(string deviceId, string jsonTwin);

        Task<Device> AddDeviceWithTagsAsync(string deviceId, Model.IoT.DeviceIoTSettings settings);

        Task<Device> AddDeviceWithTwinAsync(string deviceId, Twin twin);

    }
}
