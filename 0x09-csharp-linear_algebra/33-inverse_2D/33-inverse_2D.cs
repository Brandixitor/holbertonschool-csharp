using System;

class MatrixMath
{
    /// <summary>
    /// Method that calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix">Matrix</param>
    /// <returns>returns the resulting matrix.</returns>
    public static double[,] Inverse2D(double[,] matrix){
        if (matrix.GetLength(1) != 2 || matrix.GetLength(0) != 2){
            return new double[,]{{-1}};
        }
        var res = new double[matrix.GetLength(0),matrix.GetLength(1)];
        double determinant = 0;
        determinant = (matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1,0]);
        res[0,0] = matrix[1,1];
        res[0,1] = -matrix[0,1];
        res[1,0] = -matrix[1,0];
        res[1,1] = matrix[0,0];
        determinant = 1 / determinant; 
        
        if (determinant == System.Double.PositiveInfinity || determinant == System.Double.NegativeInfinity){
            return new double[,]{{-1}};
        }
        for (int y = 0; y < res.GetLength(0); y++){
            for (int x = 0; x < res.GetLength(1); x++){
                res[y,x] = Math.Round(determinant * res[y,x], 2);
            }
        }
        return res;
    }
}
