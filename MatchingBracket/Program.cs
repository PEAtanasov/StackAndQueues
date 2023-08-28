string input = Console.ReadLine();

Stack<int> indexes = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        indexes.Push(i);
    }
    if (input[i] == ')')
    {
        int indexOfOpenBracket = indexes.Pop();

        string result = input.Substring(indexOfOpenBracket, i - indexOfOpenBracket + 1);
        Console.WriteLine(result);
    }
}
