using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============================================================================");
        Console.WriteLine("========================== CLI Task Orginizer ==============================");
        Console.WriteLine("============================================================================");

        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine(">> What do you want to do?");
        Console.WriteLine("> 1 - Check Tasks");
        Console.WriteLine("> 2 - Add Task");
        Console.WriteLine("> 3 - Delete Task");

        string userInput = Console.ReadLine();

        if (userInput == null) {
            Console.WriteLine(">> ERROR: Need to choose a option");
        } else if (userInput == "1") { 

        }
        else if (userInput == "2")
        {

        }
        else if (userInput == "3")
        {

        }

        Console.ReadKey();
    }
}
