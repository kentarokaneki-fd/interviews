using AutoComplete.Repositories;

namespace AutoComplete;

// User requirements
// 1. Should return a list of movies that start with the user input
// 2. Should only return top 10 matches (less than 10 is okay)
// 3. Should be case insensitive
// 4. Should match any part of the movie title (update on #1)
// 5. Should be ordered by relevance (best matches first) or alphabetically if relevance is the same
//    Relevance criteria:
//    a. Titles that start with the input are more relevant than those that contain it elsewhere
//    b. Shorter titles are more relevant than longer titles when both contain the input
//    c. Titles where the input appears earlier are more relevant than those where it appears later
//    d. Titles with more total occurrences of the input are more relevant than those with less occurrences

// Bonus requirements
// 1. Should be searchable by other fields (e.g., director, year, genre)
// 2. Should handle typos in user input (e.g., "The Godfather" vs "The Godfater")

public class AutoCompleteApp
{
    public static List<string> Run(string input)
    {
        var movies = new DatabaseRepository().GetMovies();

        return movies.Select(m => m.Title).ToList();
    }
}
