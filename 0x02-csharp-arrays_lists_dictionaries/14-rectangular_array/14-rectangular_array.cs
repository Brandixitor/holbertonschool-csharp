using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[,] multiDim = new int[6, 5];
        multiDim[2,2] = 1;
        int x = 0;
        var output = new StringBuilder();
        foreach (var i in multiDim)
        {
            if (x == 5){
                Console.WriteLine(output);
                output.Clear();
                x = 0;
            }
            output.Append(i);
            if (x != 4)
                output.Append(" ");
            x += 1;
        }
    }
}
