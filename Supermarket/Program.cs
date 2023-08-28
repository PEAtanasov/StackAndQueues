string input = Console.ReadLine();

Queue<string> names = new Queue<string>();

while (input != "End")
{
    if (input == "Paid")
    {
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
        names.Clear();
    }
    else
    {
        names.Enqueue(input);
    }

    input = Console.ReadLine();
}
if (names.Any())
{
    Console.WriteLine($"{names.Count} people remaining.");
}
else
{
    Console.WriteLine("0 people remaining.");
}

