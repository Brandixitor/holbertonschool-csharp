using System;

/// <summary>
/// VectorMath main class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">vector a</param>
    /// <param name="vector2">vector b</param>
    /// <returns>Sum of vector a and b.</returns>
    public static double[] Add(double[] vector1, double[] vector2){
        if (vector1.Length != vector2.Length ||
            vector1.Length != 3 && vector1.Length != 2 || 
            vector2.Length != 3 && vector2.Length != 2){
                return (new Double[1]{-1});
        }
        var sum = new Double[3];
        for (int i = 0; i < vector1.Length; i++){
            sum[i] = vector1[i] + vector2[i];
        }
        return sum;
    }
}
