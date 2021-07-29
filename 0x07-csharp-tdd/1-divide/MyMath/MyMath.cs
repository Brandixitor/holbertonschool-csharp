using System;

namespace MyMath
{
    /// <summary>Represents a Matrix class.</summary>
    public class Matrix
    {
        /// <summary> Divide matrix elements by the given number </summary>
        /// <param name="matrix">Matrix with a given values.</param>
        /// <param name="num">Divider.</param>
        /// <returns>Divided numbers in a new matrix</returns>
        public static int[,] Divide(int[,] matrix, int num){
            if (matrix == null)
                return null;
            
            int [,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int y = 0; y < matrix.GetLength(0); y++){
                for (int x = 0; x < matrix.GetLength(1); x++){
                    try{
                        newMatrix[y,x] = matrix[y,x] / num; 
                    }
                    catch{
                        Console.WriteLine("Num cannot be 0");
                        return null; 
                    }
                }
            }
            return newMatrix;
        }
    }
}
