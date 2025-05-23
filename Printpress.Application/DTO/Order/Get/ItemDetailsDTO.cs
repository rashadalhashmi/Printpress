﻿using Printpress.Domain.Enums;
using System.Text.Json.Serialization;

namespace Printpress.Application
{
    public class ItemDetailsDTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemDetailsKeyEnum Key { get; set; }

        public string Value { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ObjectState ObjectState { get; set; }
    }
}
