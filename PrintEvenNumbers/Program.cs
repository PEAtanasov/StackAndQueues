int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> resultNumbers = new Queue<int>();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        resultNumbers.Enqueue(numbers[i]);
    }
}

Console.WriteLine(string.Join(", ", resultNumbers));

