using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

using (var client = new WebClient())
{
    var content = client.DownloadString(@"https://jsonplaceholder.typicode.com/posts");
    var posts = JsonSerializer.Deserialize<List<Post>>(content);

    foreach (var item in posts)
    {
        Console.WriteLine(item);
    }
}

class Post
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("body")]
    public string? Body { get; set; }
    public override string ToString()
    {
        return $@"{Id}. {Title}";
    }
}