using System;
using System.Text;

    class Array
    {
    public static void Reverse(int[] array)
    {
        var output = new StringBuilder();
        if (array != null)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output.Append(array[i]);
                if (i != 0)
                    output.Append(" ");
            }
        }
        Console.WriteLine(output);
    }
}