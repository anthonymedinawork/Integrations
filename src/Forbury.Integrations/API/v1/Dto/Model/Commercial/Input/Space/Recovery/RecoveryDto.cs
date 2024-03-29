﻿using Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Space.Recovery
{
    public class RecoveryDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RecoveryLeaseType Type { get; set; }
    }
}
