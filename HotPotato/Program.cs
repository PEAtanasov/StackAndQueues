string[] inNames = Console.ReadLine().Split();

int n = int.Parse(Console.ReadLine());

Queue<string> namesPlayers = new Queue<string>(inNames);

int counter = 0;

while (namesPlayers.Count > 1)
{
    counter++;
    if (counter == n)
    {
        string removedPlayer = namesPlayers.Dequeue();
        //namesPlayers.Dequeue();
        Console.WriteLine($"Removed {removedPlayer}");
        counter = 0;
        continue;
    }
    string nameToRotate = namesPlayers.Dequeue();
    namesPlayers.Enqueue(nameToRotate);
    //Console.WriteLine(counter);
}
//string winner = namesPlayers.Dequeue();
Console.WriteLine($"Last is {namesPlayers.Dequeue()}");


