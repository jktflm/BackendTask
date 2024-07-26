using Newtonsoft.Json;

namespace BackendTask
{
    public class Activity
    {
        [JsonProperty("activity")]
        public string ActivityType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("participants")]
        public int Participants { get; set; }
    }
}
