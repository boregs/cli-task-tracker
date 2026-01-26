using System;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string[]> taskKeeper = new Dictionary<string, string[]>();
        while (true)
        {
            Introduction();

            string userInput = Console.ReadLine();

            // fix this
            if (userInput == null)
            {
                Console.WriteLine(">> ERROR: You need to choose a option");
            }
            else if (userInput == "1")
            {
                DataAcess.AddTask(taskKeeper);
            }
            else if (userInput == "2")
            {
                DataAcess.ReadTask(taskKeeper);
            }
            else if (userInput == "3")
            {
                DataAcess.UpdateTask(taskKeeper);
            }
            else if (userInput == "4")
            {
                DataAcess.DeleteTask(taskKeeper);
            } 
            else if (userInput == "5")
            {
                break;
            }

        }
    }

    public static void Introduction()
    {
        Console.WriteLine("============================================================================");
        Console.WriteLine("========================== CLI Task Orginizer ==============================");
        Console.WriteLine("============================================================================");

        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine(">> What do you want to do?");
        Console.WriteLine("> 1 - Add Tasks");
        Console.WriteLine("> 2 - Check Task");
        Console.WriteLine("> 3 - Update Task");
        Console.WriteLine("> 4 - Delete Task");
        Console.WriteLine("> 5 - Exit");
    }
}
