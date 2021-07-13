using System;

class Number
{
	public static int PrintLastDigit(int number)
	{
		int lastDig = number % 10;
		if (lastDig < 0)
			lastDig = lastDig * -1;
		Console.Write(lastDig);
		return lastDig;
	}
}
