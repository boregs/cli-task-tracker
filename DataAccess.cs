using System;
using System.Net.Http.Headers;
using System.Collections.Generic;


public class DataAcess
{
    public static void addTask()
	{
       try
		{
			Dictionary<string, string[]> taskKeeper = new Dictionary<string, string[]>();
			long randLong = RandNumberGen.rand();
			string keyID = TaskIDGenerator.GenerateId(randLong);
		
		
		    Console.WriteLine(">> Give me the name of the task:");
		    Console.Write("> ");
		    string taskTitle = Console.ReadLine();
		
		    Console.WriteLine(">> Give me a brief description:");
		    Console.Write("> ");
		    string taskDesc = Console.ReadLine();
		
		    Console.WriteLine(">> When does it begin?");
		    Console.Write("> ");
		    string taskInitDate = Console.ReadLine();
		
		    Console.WriteLine(">> When does it end?");
		    Console.Write("> ");
		    string taskEndDate = Console.ReadLine();
		
		    Console.WriteLine($"Title: {taskTitle}, Description: {taskDesc}, Initial date {taskInitDate}, End date: {taskEndDate}");
		
		    taskDetails = [taskTitle, taskDesc, taskInitDate, taskEndDate];

			taskKeeper.Add(keyID, taskDetails);
			
			Console.WriteLine(">> Task Added Succesfuly");
			
			
			/*Console.WriteLine("============================== TESTING HASHMAP ==============================");
			
			foreach (KeyValuePair<string, string[]> entry in taskKeeper)
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

	public static void readTask()
	{
	}

	public static void updateTask()
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

	public static void deleteTask() 
	{
        string filePath = "test.json";

    }

}
