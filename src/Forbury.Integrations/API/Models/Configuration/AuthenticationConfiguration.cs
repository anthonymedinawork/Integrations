﻿using System.Collections.Generic;

namespace Forbury.Integrations.API.Models.Configuration
{
    public class AuthenticationConfiguration
    {
        public string Url { get; set; }
        public Dictionary<string, AuthenticationClientConfiguration> Clients { get; set; }
    }
}