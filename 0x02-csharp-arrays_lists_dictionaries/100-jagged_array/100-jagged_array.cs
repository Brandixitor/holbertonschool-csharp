using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggerArr =
        {
            new int[] { 0, 1, 2, 3 },
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] { 0, 1 }
        };

        var output = new StringBuilder();
        for (int i = 0; i < jaggerArr.Length; i++){
            output.Clear();
            for (int b = 0; b < jaggerArr[i].Length; b++){
                output.Append(jaggerArr[i][b]);
                if (jaggerArr[i].Length - 1 != b){
                    output.Append(" ");
                }
            }
            Console.WriteLine(output);
        }

    }
}