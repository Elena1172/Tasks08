//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
int[,] FillInSpiral(int r, int c)
{
    int[,] matr = new int[r, c];
    int n = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        matr[0, i] = n;
        n++;
    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        matr[i, matr.GetLength(0) - 1] = n;
        n++;
    }
    for (int i = matr.GetLength(0) - 2; i > -1; i--)
    {
        matr[matr.GetLength(0) - 1, i] = n;
        n++;
    }
    for (int i = matr.GetLength(0) - 2; i > 0; i--)
    {
        matr[i, 0] = n;
        n++;
    }
    for (int i = 1; i < matr.GetLength(0) - 1; i++)
    {
        matr[1, i] = n;
        n++;
    }
    for (int i = matr.GetLength(0) - 2; i > 0; i--)
    {
        matr[2, i] = n;
        n++;
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:00}  ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] newmatrix = FillInSpiral(4, 4);
PrintMatrix(newmatrix);