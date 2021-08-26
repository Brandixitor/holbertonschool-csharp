using System;

/// <summary>
/// VectorMath main class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that calculates dot product of either two 2D or two 3D vectors. 
    /// </summary>
    /// <param name="vector1">First vector (2D or 3D)</param>
    /// <param name="vector2">Second vector (2D or 3D)</param>
    /// <returns>returns the dot product of two vectors.</returns>
    public static double DotProduct(double[] vector1, double[] vector2){
        if (vector1.Length != vector2.Length ||
            vector1.Length != 3 && vector1.Length != 2 || 
            vector2.Length != 3 && vector2.Length != 2){
                return (-1);
        }
        double sum = 0;
        for (int x = 0; x < vector1.Length; x++){
            sum += vector1[x] * vector2[x];
        }
        return sum;
    }
}
