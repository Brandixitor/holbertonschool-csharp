using System;
using static MatrixMath;
class Test
{
    static public void Main(String[] args)
    {
        double[,] m = { { 1, 2 }, { 3, 4 } };
        var direction = "XY";
        var res = MatrixMath.Shear2D(m, direction[0], 2);
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