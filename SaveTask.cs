using System;
using System.Collections.Generic;
using System.IO;
/*
 precisa saber se ja existe um arquivo no diretorio desejado
	se sim, escreve no arquivo existente, se nao faz um novo
guardar a Key e o Value do hahsmap, alem do dia e horario que foi salvo
 */
public class SaveTasks
{
	public static void Saving(string x, Dictionary<string, string[]> y)
	{
		switch (x.ToLower()){
			case "y":
				break;

			case "n":
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string downloadFolder = Path.Combine(userProfile, "Downloads");
                string filePath = Path.Combine(downloadFolder, "MyTasks.txt");
                try
				{
					using (StreamWriter writer = new StreamWriter(filePath, false))
					{
						foreach (var entry in y)
						{
							string formatedValues = string.Join($"{entry.Key} : {entry.Value}");
                            writer.WriteLine($"{entry.Key} : {formatedValues}");
                        }
					}
					Console.WriteLine($">> Tasks saved to {filePath} successfully");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine(">> ERROR: Directory not found");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine(">> ERROR: No permition to write on the file ");
                }
                catch (Exception e)
                {
                    Console.WriteLine($">> ERROR: {e.Message}");
                }
                break;


            default:
                var filePathDefault = @"C:\Downloads\MyTasks.txt";
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePathDefault, false))
                    {
                        foreach (var entry in y)
                        {
                            writer.WriteLine($"{entry.Key} : {entry.Value}");
                        }
                    }
                    Console.WriteLine($">> Tasks saved to {filePathDefault} successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine($">> ERROR: {e}");
                }
                break;
		}
	}

	public static void Reading()
	{
	
	}
}
