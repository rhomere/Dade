using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Dade.Models
{
    public class Official
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "muniCode")]
        public string MuniCode { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "municipality")]
        public string Municipality { get; set; }

        [JsonProperty(PropertyName = "placement")]
        public string Placement { get; set; }

        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }

        [JsonProperty(PropertyName = "termLength")]
        public string TermLength { get; set; }

        [JsonProperty(PropertyName = "nextElection")]
        public string NextElection { get; set; }

    }
}
