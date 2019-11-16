using System.Text.Json.Serialization;

namespace DaprDemo.Models
{
    public class Order
    {
        [JsonPropertyName("id")]
        public string ID { get; set; }
    }
}
