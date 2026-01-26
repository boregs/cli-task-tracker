using System;

public class RandNumberGen
{
	public static long rand()
	{
		Random rnd = new Random();

		long randInt = rnd.Next(1000000000);

		return randInt;
	}
}
