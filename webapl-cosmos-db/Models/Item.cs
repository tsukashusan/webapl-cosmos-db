using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapl_cosmos_db.Models
{
    using Newtonsoft.Json;
    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "isComplete")]
        public bool Completed { get; set; }
    }
}
