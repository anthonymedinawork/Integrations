﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Forbury.Integrations.API.Interfaces;
using Forbury.Integrations.API.Models;
using Forbury.Integrations.API.Models.Configuration;
using Forbury.Integrations.Helpers.Extensions;
using IdentityServer4.Models;
using Microsoft.Extensions.Options;

namespace Forbury.Integrations.API.Services
{
    public class ForburyAuthenticationService : IForburyAuthenticationService
    {
        private readonly HttpClient _httpClient;
        private readonly ForburyConfiguration _configuration;

        public ForburyAuthenticationService(HttpClient httpClient,
            IOptions<ForburyConfiguration> configurationOptions)
        {
            _httpClient = httpClient;
            _configuration = configurationOptions.Value;
        }

        public async Task<TokenResponse> GetAccessTokenAsync()
        {
            var data = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "grant_type", GrantType.ClientCredentials },
                { "client_id", _configuration.Authentication.ClientId },
                { "client_secret", _configuration.Authentication.ClientSecret }
            });

            HttpResponseMessage response = await _httpClient.PostAsync("connect/token", data);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<TokenResponse>();
        }
    }
}
