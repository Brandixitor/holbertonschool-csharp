using System;

/// <summary>
/// MatrixMath main class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">Main matrix</param>
    /// <param name="scalar">Number for multiplication</param>
    /// <returns>New matrix after operation</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar){
        if (matrix.Length <= 1 ||
            matrix.GetLength(0) != matrix.GetLength(1)){
            return (new Double[,]{{-1}});
        }
        for (int y = 0; y < matrix.GetLength(0); y++){
            for (int x = 0; x < matrix.GetLength(1); x++){
                matrix[y,x] *= scalar;
            }
        }
        return matrix;
    }
}
