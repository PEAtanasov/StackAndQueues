string[] input = Console.ReadLine().Split();

Stack<string> exppresions = new Stack<string>(input.Reverse());

int result = int.Parse(exppresions.Pop());

while (exppresions.Any())
{
    string commandSign = exppresions.Pop();
    int currentNumber = int.Parse(exppresions.Pop());

    if (commandSign == "+")
    {
        result += currentNumber;

    }
    else if (commandSign == "-")
    {
        result -= currentNumber;

    }
}
Console.WriteLine(result);
string test = "test";