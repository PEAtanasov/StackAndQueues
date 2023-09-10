using System;

string input = Console.ReadLine();


Stack<char> stack = new Stack<char>();
Queue<char> queue = new Queue<char>();

for (int i = 0; i < input.Length / 2; i++)
{
    stack.Push(input[i]);
}

for (int i = input.Length / 2; i < input.Length; i++)
{
    queue.Enqueue(input[i]);
}

bool isSame = true;

for (int i = 0; i < stack.Count; i++)
{
    char currentStackChar = stack.Pop();
    char currentQueueChar = queue.Dequeue();
    if (currentStackChar == '(' && currentQueueChar != ')')
    {
        isSame = false;
        Console.WriteLine("NO");
        return;
    }
    else if (currentStackChar == '{' && currentQueueChar != '}')
    {
        isSame = false;
        Console.WriteLine("NO");
        return;
    }
    else if (currentStackChar == '[' && currentQueueChar != ']')
    {
        isSame = false;
        Console.WriteLine("NO");
        return;
    }
}
Console.WriteLine("YES");