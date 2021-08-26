using System;
using static MatrixMath;
class Test
{
    static public void Main(String[] args)
    {
        double[,] m = { { 3, -3 }, { 1, -1 } };
        var res = MatrixMath.Inverse2D(m);
        int i = 0;
        
        
        foreach(var elem in res){
            if (i % 2 == 0){
                Console.Write("(");
            }
            Console.Write(" " + elem + " ");
            i += 1;
            if (i % 2 == 0){
                Console.Write(")");
                Console.WriteLine();
            }
        }
    }
}