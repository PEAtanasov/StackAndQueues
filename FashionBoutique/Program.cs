int[] clothesQuantity = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> boxesOfClothes = new Stack<int>(clothesQuantity);

int rackCapacity = int.Parse(Console.ReadLine());

int rackToWork = rackCapacity;
int rackCounts = 1;

while (boxesOfClothes.Any())
{
    if (rackToWork - boxesOfClothes.Peek() >= 0)
    {
        rackToWork -= boxesOfClothes.Pop();
    }
    else
    {
        rackCounts++;
        rackToWork = rackCapacity;
    }
}
Console.WriteLine(rackCounts);