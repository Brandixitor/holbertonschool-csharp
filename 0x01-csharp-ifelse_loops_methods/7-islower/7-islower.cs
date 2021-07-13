using System;

class Character
{
	public static bool IsLower(char c)
	{
		int letter = (int)c;
		if (letter > 96 && letter < 123)
			return true;
		else
			return false;
	}
}
