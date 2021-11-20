using System.Text.Json;
using System.Text.Json.Serialization;

namespace DemoCRUDApp.Entities
{
    public class Test
    {
        [JsonPropertyName("Id")]
        public Int32 Id { get; set; }

        [JsonPropertyName("Title")]
        public String Title { get; set; }

        [JsonPropertyName("Note")]
        public String Note { get; set; }
    }
}
