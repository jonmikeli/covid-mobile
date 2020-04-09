﻿using System;

namespace IoTSolution.API.Services.Model.IoT
{
    public class Device
    {
        public string Id { get; set; }

        public string GenerationId { get; set; }

        public string ETag { get; set; }

        public string ConnectionState { get; set; }

        public string Status { get; set; }

        public string StatusReason { get; set; }

        public DateTime ConnectionStateUpdatedTime { get; set; }

        public DateTime StatusUpdatedTime { get; set; }

        public DateTime LastActivityTime { get; set; }

        public int CloudToDeviceMessageCount { get; set; }

        public string AuthenticationType { get; set; }
        public string AuthenticationPrimaryKey { get; set; }
        public string AuthenticationSecondaryKey { get; set; }
    }
}
