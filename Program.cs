using System.Collections.Generic;

Dictionary<string, string> recipes = new Dictionary<string, string>()
{
    { "pizza", "Dough, Tomato sauce, Mozzarella, Pepperoni" },
    { "spaghetti carbonara", "Spaghetti, Eggs, Parmesan, Pancetta, Black pepper" },
    { "lasagna", "Lasagna noodles, Ground beef, Tomato sauce, Ricotta, Mozzarella" },
    { "burger", "Beef patty, Burger bun, Cheese" },
    { "risotto", "Arborio rice, Chicken or vegetable broth, Parmesan, Butter" },
};
Console.WriteLine("Enter recipe name to receive its ingredients. Type 'exit' to quit.");
while (true)
{
    string input = Console.ReadLine().Trim().ToLower();
    if(string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Please enter a valid recipe name.");
        continue;
    }
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
