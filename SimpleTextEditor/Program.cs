int numberOfOperation = int.Parse(Console.ReadLine());

string result = string.Empty;
//string lastStateOfTheString = string.Empty;

Stack<string> lastStateOfTheString = new();


for (int i = 0; i < numberOfOperation; i++)
{


    string input = Console.ReadLine();

    var inputInfo = input.Split();

    string command = inputInfo[0];


    if (command == "1")
    {
        lastStateOfTheString.Push(result);
        string textToAppend = inputInfo[1];
        result += textToAppend;
    }
    else if (command == "2")
    {
        lastStateOfTheString.Push(result);
        var elementsToDelete = int.Parse(inputInfo[1]);
        result = result.Remove(result.Length - elementsToDelete);
    }
    else if (command == "3")
    {
        var index = int.Parse(inputInfo[1]);
        Console.WriteLine(result[index - 1]);
    }
    else if (command == "4")
    {
        result = lastStateOfTheString.Pop();
    }


}