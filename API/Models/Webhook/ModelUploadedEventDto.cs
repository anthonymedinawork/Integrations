﻿namespace Forbury.Integrations.API.Models.Webhook
{
    public class ModelUploadedEventDto : BaseEventDto
    {
        public int TeamId { get; set; }
        public int WorkbookInputId { get; set; }
        public string ExternalId { get; set; }
        public override WebhookType Type => WebhookType.ModelUploaded;
    }
}