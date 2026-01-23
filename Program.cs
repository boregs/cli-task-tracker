using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Introduction();

            string userInput = Console.ReadLine();

            if (userInput == null)
            {
                Console.WriteLine(">> ERROR: You need to choose a option");
            }
            else if (userInput == "1")
            {
                DataAcess.ReadTask();
            }
            else if (userInput == "2")
            {
                DataAcess.AddTask();
            }
            else if (userInput == "3")
            {

            }
            else if (userInput == "4")
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
        Console.WriteLine("> 1 - Check Tasks");
        Console.WriteLine("> 2 - Add Task");
        Console.WriteLine("> 3 - Delete Task");
        Console.WriteLine("> 4 - Leave");
    }
}
