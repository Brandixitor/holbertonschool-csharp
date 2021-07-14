using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++){
            for (int b = 0; b < myMatrix.GetLength(1); b++){
                myMatrix[i, b] *= myMatrix[i, b];
            }
        }
        return myMatrix;
    }
}