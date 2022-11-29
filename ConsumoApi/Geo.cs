namespace QuickType
{
    using Newtonsoft.Json;

    public partial class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}

