using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dade.Models
{
    public class Municipality
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "population")]
        public string Population { get; set; }

        [JsonProperty(PropertyName = "muniCode")]
        public string MuniCode { get; set; }

        [JsonProperty(PropertyName = "muniName")]
        public string MuniName { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }
    }
}
