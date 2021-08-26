using System;
using static MatrixMath;
class Test
{
    static public void Main(String[] args)
    {
        double[,] m = { { -4, 9, 0 }, { 1, -2, 1 }, {3, -4, 2} };
        var res = MatrixMath.Determinant(m);
        
        Console.WriteLine(res);
    }
}