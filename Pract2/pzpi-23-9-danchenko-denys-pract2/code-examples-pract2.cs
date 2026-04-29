using System.Net.Http;
using System.Net.Http.Headers;

var client = new HttpClient();
string accessToken = "USER_ACCESS_TOKEN";
string trackId = "TRACK_ID";

client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var response = await client.GetAsync(
    $"https://api.spotify.com/v1/tracks/{trackId}");

string result = await response.Content.ReadAsStringAsync();
Console.WriteLine(result);

/* */

public class ListeningEvent
{
    public string UserId { get; set; }
    public string TrackId { get; set; }
    public string Action { get; set; }
    public DateTime CreatedAt { get; set; }
}

public async Task SendListeningEventAsync()
{
    var listeningEvent = new ListeningEvent
    {
        UserId = "user123",
        TrackId = "track456",
        Action = "play",
        CreatedAt = DateTime.UtcNow
    };

    await recommendationService.ProcessEventAsync(listeningEvent);
}
