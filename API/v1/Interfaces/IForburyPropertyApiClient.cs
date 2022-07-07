﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyPropertyApiClient
    {
        Task<PagedResult<PropertyDto>> GetProperties(int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<PropertyDetailedDto> GetPropertyById(int propertyId,
            CancellationToken cancellationToken = default);

        Task<PagedResult<ModelDto>> GetModelsByPropertyId(int propertyId,
            DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<ModelDetailedDto> GetModelByPropertyId(int propertyId,
            int modelId,
            CancellationToken cancellationToken = default);
    }
}
