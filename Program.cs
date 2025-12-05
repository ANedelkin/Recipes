using System.Collections.Generic;

Dictionary<string, string> recipes = new Dictionary<string, string>()
{
    { "pizza", "Dough, Tomato sauce, Mozzarella, Pepperoni" },
};
Console.WriteLine("Enter recipe name to receive its ingredients. Type 'exit' to quit.");
while (true)
{
    string input = Console.ReadLine().ToLower();
    if(input == "exit")
    {
        return;
    }
    if (!recipes.ContainsKey(input))
    {
        Console.WriteLine("No such recipe.");
    }
    else
    {
        Console.WriteLine(recipes[input]);
    }
}
