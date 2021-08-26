using System;

/// <summary>
/// VectorMath main class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">Vector to multiply</param>
    /// <param name="scalar">Number of multiplication</param>
    /// <returns>returns the resulting vector after multiplication.</returns>
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length != 3 && vector.Length != 2){
                return (new Double[1]{-1});
        }
        var sum = new Double[vector.Length];
        for (int i = 0; i < vector.Length; i++){
            sum[i] = vector[i] * scalar;
        }
        return sum;
    }
}
