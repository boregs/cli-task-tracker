using System;
using System.Net.Http.Headers;
using System.Text.Json;


public class DataAcess
{
	public static void addTask()
	{
        var newTask = new Task {id = 1, title = "oi", description = "teste"};

		try
		{
			// passando para o arquivo json "formatando" as informaçoes
			var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(newTask, options);

			string filePath = "test.json";
			File.WriteAllText(filePath, jsonString);

            Console.WriteLine(">> Add Task: Sucessfull");
        }
		catch (Exception ex)
		{
            Console.WriteLine($">> ERROR: {ex.Message}");
        }
		
    }

	public static void readTask()
	{
		string filePath = "test.json";

		try
		{
			string jsonString = File.ReadAllText(filePath);

			Task task = JsonSerializer.Deserialize<Task>(jsonString);

			Console.WriteLine($"Read Task: ");
		} 
			catch (FileNotFoundException)
			{
				Console.WriteLine($">> ERROR: The file {filePath} was not found or it does not exist");
			} 
				catch (JsonException ex)
				{
					 Console.WriteLine($">> ERROR PARSING JSON: {ex.Message}");
				}
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
