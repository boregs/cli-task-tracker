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
		
			Console.WriteLine(">> What task do you want to add?");
		    Console.Write("> ");
		    string taskTitle = Console.Read().ToString();
		
		    Console.WriteLine(">> Give me a brief description of the task");
		    Console.Write("> ");
		    string taskDesc = Console.Read().ToString();
		
		    Console.WriteLine(">> When does it begin");
		    Console.Write("> ");
			string taskInitialDate = Console.Read().ToString();
		
		    Console.WriteLine(">> When does it end?");
		    Console.Write("> ");
		    Console.Read();
			string taskEndDate = Console.Read().ToString();




            //taskKeeper.Add(keyID);


            Console.WriteLine(">> Task Added Succesfuly");
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
