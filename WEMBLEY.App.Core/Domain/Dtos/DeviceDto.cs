﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEMBLEY.App.Core.Domain.Dtos
{
    public class DeviceDto
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public int DisplayPriority { get; set; }

        public DeviceDto(string deviceId, string deviceName, string deviceType, int displayPriority)
        {
            DeviceId = deviceId;
            DeviceName = deviceName;
            DeviceType = deviceType;
            DisplayPriority = displayPriority;
        }
    }
}
