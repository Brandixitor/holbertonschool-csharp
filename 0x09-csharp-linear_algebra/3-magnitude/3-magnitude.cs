using System;
/// <summary>
/// VectorMath main class. 
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that calculates and returns the length of a given vector.
    /// </summary>
    /// <param name="vector">2D or 3D vector.</param>
    /// <returns>returns the length rounded to the nearest hundredth.</returns>
    public static double Magnitude(double[] vector){
        if (vector.Length != 3 && vector.Length != 2){
            return (-1);
        }
        double sum = 0;
        foreach (var elem in vector){
            sum += elem * elem;
        }
        return System.Math.Round(System.Math.Sqrt(sum), 2);
    }
}
