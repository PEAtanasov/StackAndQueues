int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();
    int[] commandInfo = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int commanToDo = commandInfo[0];
    int numberToPush = 0;

    if (commandInfo.Length > 1)
    {
        numberToPush = commandInfo[1];
    }

    if (commanToDo == 1)
    {
        stack.Push(numberToPush);
    }
    else if (commanToDo == 2)
    {
        stack.Pop();
    }
    else if (commanToDo == 3)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if (commanToDo == 4)
    {
        if (stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stack));