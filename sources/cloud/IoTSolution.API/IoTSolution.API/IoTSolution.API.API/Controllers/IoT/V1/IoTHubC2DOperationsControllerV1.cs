using System;
using System.Threading.Tasks;

using AutoMapper;

using IoTSolution.API.API.DataContracts.IoT;
using IoTSolution.API.API.DataContracts.IoT.Requests;
using IoTSolution.API.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Devices;//WARNING: this reference should not be done. It has been included only for JobResponse and save time for the project.

using Newtonsoft.Json;

using SIoT = IoTSolution.API.Services.Model.IoT;


namespace IoTSolution.API.API.Controllers.IoT.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/devices")]
    [Route("api/v{version:apiVersion}/devices")]
    public class IoTHubC2DOperationsControllerV1 : Controller
    {
        private readonly IIoTHubC2DOperationsService _iotService;
        private readonly IMapper _mapper;

#pragma warning disable CS1591
        public IoTHubC2DOperationsControllerV1(IIoTHubC2DOperationsService iotService, IMapper mapper)
        {
            _iotService = iotService;
            _mapper = mapper;
        }
#pragma warning restore CS1591

        #region GET
        /// <summary>
        /// Gets the Twin properties of a given device.
        /// </summary>
        /// <param name="id">Device Id</param>
        /// <returns>Twin properties.</returns>
        /// <response code="200">Returns the item corresponding to the provided Id.</response>
        /// <response code="204">If the item is null.</response>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Twins))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(Twins))]
        [HttpGet("{id}/twin")]
        public async Task<Twins> Get(string id)
        {
            var data = await _iotService.GetTwinsAsync(id);

            if (data != null)
                return _mapper.Map<Twins>(data);
            else
                return null;
        }
        #endregion

        #region PUT
        /// <summary>
        /// Invokes a direct method (C2D) according to the given parameters in the request.
        /// </summary>
        /// <param name="request">DirectMethodInvoqueRequest.</param>
        /// <returns>String, with the job call request.</returns>
        /// <response code="200">Returns a string with the job id.</response>
        [HttpPut()]
        [Route("invoke")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<string> InvokeDirectMethodAsync([FromBody] DirectMethodInvoqueRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            return await _iotService.InvokeDirectMethodAsync(request.DeviceId, request.MethodName, request.Payload);
        }

        /// <summary>
        /// Updates the Tags in the Twin properties of a given device.
        /// </summary>
        /// <param name="request">TwinUpdateRequest</param>
        /// <returns>Twin properties.</returns>
        /// <response code="200">Returns updated Twin.</response>
        [HttpPut()]
        [Route("twin/tags/update")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Twins))]
        public async Task<Twins> UpdateTwinTagsAsync([FromBody]TwinUpdateRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.TwinTags == null)
                throw new ArgumentNullException("Tags");

            var businessRequestTags = _mapper.Map<SIoT.Tags>(request.TwinTags);

            if (businessRequestTags != null)
            {
                SIoT.Twins data = await _iotService.UpdateTwinsAsync(request.DeviceId, JsonConvert.SerializeObject(new { tags = businessRequestTags }));

                if (data != null)
                    return _mapper.Map<Twins>(data);
                else
                    return null;
            }
            else
                return null;

        }

        /// <summary>
        /// Updates Twin properties of a given device.
        /// </summary>
        /// <param name="request">TwinUpdateRequest.</param>
        /// <returns>Twin properties.</returns>
        /// <response code="200">Returns updated Twin.</response>
        [HttpPut()]
        [Route("twin/properties/update")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Twins))]
        public async Task<Twins> UpdateTwinPropertiesAsync([FromBody]TwinUpdateRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.TwinProperties == null)
                throw new ArgumentNullException("Properties");

            var businessRequestProperties = _mapper.Map<SIoT.Properties>(request.TwinProperties);

            if (businessRequestProperties != null)
            {
                SIoT.Twins data = await _iotService.UpdateTwinsAsync(request.DeviceId, JsonConvert.SerializeObject(new { properties = businessRequestProperties }));

                if (data != null)
                    return _mapper.Map<Twins>(data);
                else
                    return null;
            }
            else
                return null;
        }

        /// <summary>
        /// Updates Twin properties through an IoT Hub job.
        /// </summary>
        /// <param name="request">TwinUpdateJobRequest</param>
        /// <returns>String with the result of the IoT Hub job call.</returns>
        /// <response code="200">Returns a string with the job id.</response>
        [HttpPut()]
        [Route("twin/properties/jobs/run")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<string> RunTwinPropertiesUpdateJobAsync([FromBody]TwinUpdateJobRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.TwinProperties == null)
                throw new ArgumentNullException("Properties");

            string jobId = Guid.NewGuid().ToString();

            var twin = new SIoT.Twins();
            twin.Properties = _mapper.Map<SIoT.Properties>(request.TwinProperties);

            if (twin.Properties != null)
            {

                //Send Twins but build new Twin Azure object at service level.
                var serviceRequest = new SIoT.TwinsSearchRequest();
                serviceRequest.WhereCondition = request.WhereConstraint;

                await _iotService.RunTwinUpdateJobAsync(jobId, request.WhereConstraint, twin);

                return jobId;
            }
            else return string.Empty;

        }

        /// <summary>
        /// Updates Tags in the Twin properties of the devices fulfilling the requirements of the request (operation completed through an IoT Hub job).
        /// </summary>
        /// <param name="request">TwinUpdateJobRequest</param>
        /// <returns>String with the result of the IoT Hub job call.</returns>
        /// <response code="200">Returns a string with the job id.</response>
        [HttpPut()]
        [Route("twin/tags/jobs/run")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<string> RunTwinTagsUpdateJobAsync([FromBody]TwinUpdateJobRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.TwinTags == null)
                throw new ArgumentNullException("Tags");

            string jobId = Guid.NewGuid().ToString();

            var twin = new SIoT.Twins();
            twin.Tags = _mapper.Map<SIoT.Tags>(request.TwinTags);

            if (twin.Tags != null)
            {

                //Send Twins but build new Twin Azure object at service level.
                var serviceRequest = new SIoT.TwinsSearchRequest();
                serviceRequest.WhereCondition = request.WhereConstraint;

                await _iotService.RunTwinUpdateJobAsync(jobId, request.WhereConstraint, twin);

                return jobId;
            }
            else return string.Empty;

        }

        /// <summary>
        /// Gets the status of a given IoT Hub job.
        /// </summary>
        /// <param name="jobId">JobId</param>
        /// <returns>Status</returns>
        /// <response code="200">Job status.</response>
        [HttpGet()]
        [Route("twin/jobs/{jobId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JobResponse))]
        public async Task<JobResponse> MonitorJobWithDetailsAsync(string jobId)
        {
            if (string.IsNullOrEmpty(jobId))
                throw new ArgumentNullException("jobId");

            return await _iotService.MonitorJobWithDetailsAsync(jobId);
        }

        #endregion
    }

}
