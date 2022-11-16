using System.Text.Json.Serialization;
public class Pokemon
{
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("weight")]
    public int weight { get; set; }

    [JsonPropertyName("isdefault")]
    public bool is_default { get; set; }

    [JsonPropertyName("height")]
    public int height { get; set; }
}
