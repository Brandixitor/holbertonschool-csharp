using System;

/// <summary>
/// MatrixMath main class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">First matrix (2D or 3D)</param>
    /// <param name="matrix2">Second matrix (2D or 3D)</param>
    /// <returns>returns the resulting matrix.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2){
        
        if (matrix1.Length != matrix2.Length ||
            matrix1.GetLength(0) != matrix1.GetLength(1) ||
            matrix2.GetLength(0) != matrix2.GetLength(1)){
                return (new Double[,]{{-1}});
        }
        double[,] result = new double[matrix1.GetLength(0),matrix1.GetLength(1)];
        for (int y = 0; y < matrix1.GetLength(0); y++){
            for (int x = 0; x < matrix1.GetLength(1); x++){
                result[y, x] = matrix1[y,x] + matrix2[y,x];
            }
        }
        return result;
    }
}
