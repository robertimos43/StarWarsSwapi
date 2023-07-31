using Newtonsoft.Json;

namespace StarWarsCharacters.Models;

public class FilmResponse
{
    [JsonProperty("characters")]
    public string[] characters { get; set; }
    [JsonProperty("created")]
    public string created { get; set; }
    [JsonProperty("director")]
    public string director { get; set; }
    [JsonProperty("edited")]
    public string edited { get; set; }
    [JsonProperty("episode_id")]
    public int episode_id { get; set; }
    [JsonProperty("opening_crawl")]
    public string opening_crawl { get; set; }
    [JsonProperty("planets")]
    public string[] planets { get; set; }
    [JsonProperty("producer")]
    public string producer { get; set; }
    [JsonProperty("release_date")]
    public string release_date { get; set; }
    [JsonProperty("species")]
    public string[] species { get; set; }
    [JsonProperty("starships")]
    public string[] starships { get; set; }
    [JsonProperty("title")]
    public string title { get; set; }
    [JsonProperty("url")]
    public string url { get; set; }
    [JsonProperty("vehicles")]
    public string[] vehicles { get; set; }
}
