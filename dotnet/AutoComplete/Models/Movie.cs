using System.Text.Json.Serialization;

namespace AutoComplete.Models;

public record Movie
{
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("year")]
    public int Year { get; init; }

    [JsonPropertyName("genre")]
    public required string Genre { get; init; }

    [JsonPropertyName("lengthMinutes")]
    public int LengthMinutes { get; init; }

    [JsonPropertyName("director")]
    public required string Director { get; init; }
}
