using System;
using System.IO;

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
                TaskRepository.AddTask(taskKeeper);
            }
            else if (userInput == "2")
            {
                TaskRepository.ReadTask(taskKeeper);
            }
            else if (userInput == "3")
            {
                Console.WriteLine(">> WARNING: Updating a task only applies to unsaved tasks." +
                    "If you want to update a saved task, you have to do it manualy\n");
                Thread.Sleep(500);
                TaskRepository.UpdateTask(taskKeeper);
            }
            else if (userInput == "4")
            {
                Console.WriteLine(">> WARNING: Deleting a task only applies to unsaved tasks." +
                    "If you want to delete a saved task, you have to do it manualy\n");
                Thread.Sleep(500);
                TaskRepository.DeleteTask(taskKeeper);
            } 
            else if (userInput == "5")
            {
                SaveTasks.Reading();
            }
            else if (userInput == "6")
            {
                Console.WriteLine(">> Leave without saving? (y/N)");
                string leaveChoise = Console.ReadLine().ToLower();

                if (leaveChoise.ToLower() == "y")
                {
                    break;
                }
                SaveTasks.Saving(leaveChoise, taskKeeper);

                break;
            }

        }
    }

    public static void Introduction()
    {
        Console.WriteLine("============================================================================");
        Console.WriteLine("========================== CLI Task Orginizer ==============================");
        Console.WriteLine("============================================================================");

        Console.WriteLine("\n----------------------------------------------------------------------------");
        Console.WriteLine(">> What do you want to do?");
        Console.WriteLine("> 1 - Add Tasks");
        Console.WriteLine("> 2 - Check Tasks");
        Console.WriteLine("> 3 - Update Task");
        Console.WriteLine("> 4 - Delete Task");
        Console.WriteLine("> 5 - See Saved Tasks");
        Console.WriteLine("> 6 - Exit");
    }
}
