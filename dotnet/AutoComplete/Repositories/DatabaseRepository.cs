using System.Text.Json;
using AutoComplete.Models;

namespace AutoComplete.Repositories;

public class DatabaseRepository
{
    private static readonly string DATA_FILE_PATH = "data/bestPictureWinners.json";

    public List<Movie> GetMovies()
    {
        return GetMovieTitlesFromJson();
    }
    
    private List<Movie> GetMovieTitlesFromJson()
    {
        if (!File.Exists(DATA_FILE_PATH))
        {
            throw new Exception("Data file not found.");
        }

        var json = File.ReadAllText(DATA_FILE_PATH);
        return JsonSerializer.Deserialize<List<Movie>>(json) ?? [];
    }
}
