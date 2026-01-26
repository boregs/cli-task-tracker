using System;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;


public class DataAcess
{
    public static void AddTask(Dictionary<string, string[]> x)
    {
        try
        {
            long randLong = RandNumberGen.Rand();
            string keyID = TaskIDGenerator.GenerateId(randLong);
            string[] taskDetails;

            Console.WriteLine(">> Give me the name of the task:");
            Console.Write("> ");
            string taskTitle = Console.ReadLine();

            Console.WriteLine(">> Give me a brief description:");
            Console.Write("> ");
            string taskDesc = Console.ReadLine();

            Console.WriteLine(">> When does it begin?");
            Console.WriteLine(">> NOTE: Please format the date with: DD-MM-YYYY");
            Console.Write("> ");
            string taskInitDate = Console.ReadLine();

            Console.WriteLine(">> When does it end?");
            Console.WriteLine(">> NOTE: Please format the date with: DD-MM-YYYY");
            Console.Write("> ");
            string taskEndDate = Console.ReadLine();

            Console.WriteLine($"\nTitle: {taskTitle}, Description: {taskDesc}, Initial date {taskInitDate}, End date: {taskEndDate}\n");

            taskDetails = [taskTitle, taskDesc, taskInitDate, taskEndDate];

            x.Add(keyID, taskDetails);

            Thread.Sleep(1000);

            Console.WriteLine(">> Task Added Succesfuly\n");


            /* Console.WriteLine("============================== TESTING HASHMAP ==============================");
			
			foreach (KeyValuePair<string, string[]> entry in x)
			{
				string key = entry.Key;
				string[] values = entry.Value;

				Console.Write($"ID: {key}  |  ");
                Console.Write("Contents: ");
                Console.Write($"[{string.Join(",", values)}]");
			}
			*/
            Thread.Sleep(2500);
            Console.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($">> ERROR: {ex.Message}\n");
        }
        Console.Clear();
    }


    // need to fix this method
    public static void ReadTask(Dictionary<string, string[]> x)
    {
        long randLong = RandNumberGen.Rand();
        string keyID = TaskIDGenerator.GenerateId(randLong);

        Console.WriteLine(">> Do you want to see all tasks? (Y/n)");
        Console.WriteLine(">> Y - Yes (Recommended)");
        Console.WriteLine(">> n - No");

        string userInput = Console.ReadLine().ToLower();

        if (userInput == "y")
        {
            try
            {
                foreach (KeyValuePair<string, string[]> entry in x)
                {
                    string key = entry.Key;
                    string[] values = entry.Value;

                    Console.Write($"\nID: {key}  |  ");
                    Console.Write("Contents: ");
                    Console.Write($"[{string.Join(" | ", values)}]\n");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($">> ERROR: {ex.Message}\n");
            }
        }
        else if (userInput == "n")
        {

            Console.WriteLine(">> Please Inform the ID of the task:");
            Console.WriteLine(">> NOTE: Please use the exact ID");
            Console.WriteLine(">");
            string taskID = Console.ReadLine();

            // searches the ID(key) on the hashmap
            if (x.ContainsKey(taskID))
            {
                Thread.Sleep(500);
                Console.WriteLine($"Task {taskID} found. Content: {x[taskID]}");
            }
            else {
                Console.WriteLine($">> ERROR: No results found for the ID '{taskID}'. " +
                $"Check your spelling or try a different ID.\n");
                DataAcess.ReadTask(x);
            }
        }
        else
        {
            Console.WriteLine(">> ERROR: Please choose an available option\n");
        }
        
    }

    public static void UpdateTask(Dictionary<string, string[]> x)
    {
        Console.WriteLine("------------------------------ Your Tasks ------------------------------\n");

        foreach (KeyValuePair<string, string[]> entry in x)
        {
            string key = entry.Key;
            string[] values = entry.Value;

            Console.Write($"ID: {key}  |  ");
            Console.Write("Contents: ");
            Console.Write($"[{string.Join(" | ", values)}]\n");
        }

        Console.WriteLine(">> Which task do you want to update?");
        Console.WriteLine(">> NOTE: Please inform the exact ID");
        string userChoice = Console.ReadLine();

        if (x.ContainsKey(userChoice) == false)
        {
            Console.WriteLine($">> ERROR: No results found for the ID '{userChoice}'. " +
                $"Check your spelling or try a different ID.\n");
            DataAcess.UpdateTask(x);
        }
        string[] newTaskDetails;

        Console.WriteLine($">> ID '{userChoice}' Found.");

        Console.WriteLine(">> NOTE: Rewrite what you do not want to update! \n");

        Console.WriteLine(">> Give me the new name of the task:");
        Console.Write("> ");
        string taskTitle = Console.ReadLine();

        Console.WriteLine(">> Give a new brief description:");
        Console.Write("> ");
        string taskDesc = Console.ReadLine();

        Console.WriteLine(">> Now, when does it begin?");
        Console.WriteLine(">> NOTE: Please format the date with: DD-MM-YYYY");
        Console.Write("> ");
        string taskInitDate = Console.ReadLine();

        Console.WriteLine(">> Now, when does it end?");
        Console.WriteLine(">> NOTE: Please format the date with: DD-MM-YYYY");
        Console.Write("> ");
        string taskEndDate = Console.ReadLine();

        Console.WriteLine($"Title: {taskTitle}, Description: {taskDesc}, Initial date {taskInitDate}, End date: {taskEndDate}");

        newTaskDetails = [taskTitle, taskDesc, taskInitDate, taskEndDate];

        x[userChoice] = newTaskDetails;

        Thread.Sleep(1000);

        Console.WriteLine("\n>> Task Updated Succesfuly\n");

        Thread.Sleep(1500);
        Console.Clear();
    }

    public static void DeleteTask(Dictionary<string, string[]> x)
    {
        Console.WriteLine("------------------------------ Your Tasks ------------------------------\n");

        foreach (KeyValuePair<string, string[]> entry in x)
        {
            string key = entry.Key;
            string[] values = entry.Value;

            Console.Write($"\nID: {key}  |  ");
            Console.Write("Contents: ");
            Console.Write($"[{string.Join(" | ", values)}]");
            Console.Write("\n");
        }

        Console.WriteLine(">> Which task do you want to delete?");
        Console.WriteLine(">> NOTE: Please inform the exact ID");
        string userChoice = Console.ReadLine();
    }
}

