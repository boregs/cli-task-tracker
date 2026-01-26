using System;
using System.Net.Http.Headers;
using System.Collections.Generic;


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

            Console.WriteLine($"Title: {taskTitle}, Description: {taskDesc}, Initial date {taskInitDate}, End date: {taskEndDate}");

			taskDetails = [taskTitle, taskDesc, taskInitDate, taskEndDate];

            x.Add(keyID, taskDetails);

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
        }
		catch (Exception ex)
		{
            Console.WriteLine($">> ERROR: {ex.Message}");
        }
		
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
                    Console.Write($"[{string.Join(" | ", values)}]");
                    Console.Write("\n");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($">> ERROR: {ex.Message}");
            }
        }
        else if (userInput == "n") {

            Console.WriteLine(">> Please Inform the ID of the task:");
            Console.WriteLine(">> NOTE: Please use the exact ID");
            Console.WriteLine(">");
            string taskID = Console.ReadLine();
            
            // searches the ID(key) on the hashmap
            if (x.ContainsKey(taskID))
            {
                Console.WriteLine($"Task {taskID} found. Content: {x[taskID]}");
            }
        }
        else
        {
            Console.WriteLine(">> ERROR: Please choose an available option");
        }
    }

	public static void UpdateTask()
	{
		string filePath = "test.json";

		/*try
		{

		}
		catch ()
		{

		}

		/*
		 pergunta qual task voce quer modificar
		 verifica no json se o id da task existe
		 se existir, mostrar a task e perguntar se quer reescrever
		 se nao, devolver erro
		 */
	}

	public static void DeleteTask() 
	{
        string filePath = "test.json";

    }

}
