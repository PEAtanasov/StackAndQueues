string[] input = Console.ReadLine().Split();

Stack<string> exppresions = new Stack<string>(input.Reverse());

int result = int.Parse(exppresions.Pop());

while (exppresions.Any())
{
    string sign = exppresions.Pop();
    int currentNumber = int.Parse(exppresions.Pop());

    if (sign == "+")
    {
        result += currentNumber;

    }
    else if (sign == "-")
    {
        result -= currentNumber;

    }
}
Console.WriteLine(result);
