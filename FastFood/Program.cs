int quantityOfFood = int.Parse(Console.ReadLine());

int[] ordersInfo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> orders = new Queue<int>(ordersInfo);

Console.WriteLine(orders.Max());

while (orders.Any())
{
    if (quantityOfFood - orders.Peek() >= 0)
    {
        quantityOfFood -= orders.Dequeue();
    }
    else
    {
        break;
    }
}
if (orders.Any())
{
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}
else
{
    Console.WriteLine("Orders complete");
}


