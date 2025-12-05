using System.Collections.Generic;

Dictionary<string, string> recipes = new Dictionary<string, string>();
Console.WriteLine("Enter recipe name to receive its ingredients. Type 'exit' to quit.");
while (true)
{
    string input = Console.ReadLine();
    if(input == "exit")
    {
        return;
    }
}
