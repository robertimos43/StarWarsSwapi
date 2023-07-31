using System.Net;
using Newtonsoft.Json;
using Sane.Http.HttpResponseExceptions;
using StarWarsCharacters.Models;

namespace StarWarsCharacters;

public class SwapiService
{
    private readonly HttpClient _client;
    public SwapiService(HttpClient client)
    {
        client.BaseAddress = new Uri("https://swapi.dev/api/");
        _client = client;
    }

    public async Task<IEnumerable<PeopleResponseResult>> GetPeopleAsync()
    {
        var response = await _client.GetAsync(requestUri: "people");
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<PeopleResponseResult>();
        }

        var content = await response.Content.ReadAsStringAsync();
        var deserialized = JsonConvert.DeserializeObject<PeopleResponse>(content);
        return deserialized.Response;
    }

    public async Task<PeopleResponseResult> GetPeopleByIdAsync(string id)
    {
        var response = await _client.GetAsync(requestUri: $"people/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var content = await response.Content.ReadAsStringAsync();
        var deserialized = JsonConvert.DeserializeObject<PeopleResponseResult>(content);
        return deserialized;
    }
}

//rzeczy z końcówką async - dodajemy await