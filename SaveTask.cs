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
			case "n":
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string downloadFolder = Path.Combine(userProfile, "Downloads");
                string filePath = Path.Combine(downloadFolder, "MyTasks.txt");

                if (File.Exists(filePath) == false) {

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, false))
                        {
                            foreach (KeyValuePair<string, string[]> entry in y)
                            {
                                string key = entry.Key;
                                string[] values = entry.Value;
                                writer.WriteLine($"{key} : [{string.Join(" | ", values)}]\n");

                            }
                        }
                        Console.WriteLine($">> Tasks saved to {filePath} successfully");

                    } catch (DirectoryNotFoundException){
                        Console.WriteLine(">> ERROR: Directory not found");

                    } catch (UnauthorizedAccessException){
                        Console.WriteLine(">> ERROR: No permition to write on the file ");

                    } catch (Exception e){
                        Console.WriteLine($">> ERROR: {e.Message}");
                    }

                } else {
                    try
                    {
                        foreach (KeyValuePair<string, string[]> entry in y)
                        {
                            string key = entry.Key;
                            string[] values = entry.Value;
                            File.AppendAllText(filePath, $"{key} : [{string.Join(" | ", values)}]\n");

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
                }

                break;

            default:
                string userProfileDefault = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string downloadFolderDefault = Path.Combine(userProfileDefault, "Downloads");
                string filePathDefault = Path.Combine(downloadFolderDefault, "MyTasks.txt");

                if (File.Exists(filePathDefault) == false)
                {

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePathDefault, false))
                        {
                            foreach (KeyValuePair<string, string[]> entry in y)
                            {
                                string key = entry.Key;
                                string[] values = entry.Value;
                                writer.WriteLine($"{key} : [{string.Join(" | ", values)}]\n");

                            }
                        }
                        Console.WriteLine($">> Tasks saved to {filePathDefault} successfully");

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

                }
                else
                {
                    try
                    {
                        foreach (KeyValuePair<string, string[]> entry in y)
                        {
                            string key = entry.Key;
                            string[] values = entry.Value;
                            File.AppendAllText(filePathDefault, $"{key} : [{string.Join(" | ", values)}]\n");

                        }

                        Console.WriteLine($">> Tasks saved to {filePathDefault} successfully");

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
                }

                break;
        }
	}

	public static void Reading()
	{
        string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string downloadFolder = Path.Combine(userProfile, "Downloads");
        string filePath = Path.Combine(downloadFolder, "MyTasks.txt");

        try { 
            Console.WriteLine(File.ReadAllText(filePath));
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine(">> ERROR: Directory not found, check to see if you have a 'MyTasks.txt' file on" +
                "your download folder ");

        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(">> ERROR: No permition to read the file ");

        }
        catch (Exception e)
        {
            Console.WriteLine($">> ERROR: {e.Message}");
        }
    }
}
