namespace DaprDemo.Models
{
    using System.Text.Json.Serialization;

    public class Order
    {
        [JsonPropertyName("id")]
        public string ID { get; set; }
    }
}
