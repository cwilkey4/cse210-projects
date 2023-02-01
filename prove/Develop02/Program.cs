using System;

public class Write
{
    public static void main()
    {
        string[] cwPrompts = new string[5]; 
        cwPrompts[0] = "I am happy because... ";
        cwPrompts[1] = "What did I learn today? ";
        cwPrompts[2] = "What do I want to do tomorrow to make it great? ";
        cwPrompts[3] = "Today, I was inspired by... ";
        cwPrompts[4] = "How did I give and receive appreciation today? ";
        Random cwRandomize = new Random();
        int cwPromptNumber = cwRandomize.Next(4);
        Console.WriteLine(cwPrompts[cwPromptNumber]);
        string cwUserEntry = Console.ReadLine();
        // Remove this part later
        Console.WriteLine(cwUserEntry);
    }

}

// using Newtonsoft.Json;
// class Program
// {

// public class Main
// {

//     public void Write()
//     {
//         deConsole.WriteLine("Write");
//         string fileName = "journal.json";
//         string jsonString = File.ReadAllText("journal.json");


//     }
//     public void Display()
//     {
//         deConsole.WriteLine("Display");
//         string fileName = "journal.json";
//         string jsonString = File.ReadAllText("journal.json");
//         foreach (var entry in jsonObject["entries"])
//         {
//             Console.WriteLine("entry number: {0}", entry.Name);
//             Console.WriteLine("prompt: {0}", entry.Value["prompt"]);
//             Console.WriteLine("response: {0}", entry.Value["response"]);
//         }

//     }
//     public void Load()
//     {
//         deConsole.WriteLine("Load");
//         string fileName = "journal.json";
//         string jsonString = File.ReadAllText("journal.json");
//         jsonConvert.DeserializeObject < Dictionary < "entry prompt" >> (jsonString);

//     }
//     public void Save()
//     {
//         deConsole.WriteLine("Save");
//         string fileName = "journal.json";
//         string jsonString = File.ReadAllText("journal.json");
//         fileName.WriteAllText("journal.json");
//     }
//     public void Quit()
//     {
//         deConsole.WriteLine("Quit");
//         string fileName = "journal.json";
//         string jsonString = File.ReadAllText("journal.json");
//     }
// }
// }