using System;
class Test
{
    static public void Main(String[] args)
    {
        double[] v = {7,-2, 0 };
        double[] u = {-4,3, 6};
        var res = VectorMath.CrossProduct(v, u);
        
        foreach(var elem in res){
            Console.WriteLine(elem);
        }
    }
}