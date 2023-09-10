string[] songs = Console.ReadLine().Split(", ");

Queue<string> playList = new Queue<string>(songs);

string command = Console.ReadLine();

while (playList.Any())
{
    if (command.Contains("Add"))
    {
        string songToAdd = command.Substring(4, command.Length - 4);

        //Console.WriteLine(songToAdd);

        if (!playList.Contains(songToAdd))
        {
            playList.Enqueue(songToAdd);
        }
        else
        {
            Console.WriteLine($"{songToAdd} is already contained!");
        }
    }
    else if (command.Contains("Play"))
    {
        playList.Dequeue();
    }
    else if (command.Contains("Show"))
    {
        Console.WriteLine(string.Join(", ", playList));
    }



    command = Console.ReadLine();
}
Console.WriteLine("No more songs!");
