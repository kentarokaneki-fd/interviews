using AutoComplete;

var userInput = string.Join(" ", args);

var results = AutoCompleteApp.Run(userInput);

Console.WriteLine("Matches:");
foreach (var title in results)
{
    Console.WriteLine(title);
}
