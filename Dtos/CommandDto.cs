using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace BlazorAPIClient.Dtos
{
    public class CommandDto
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("howTo")]
        public string HowTo { get; set; }

        [JsonPropertyName("line")]
        public string Line { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }
    }
}