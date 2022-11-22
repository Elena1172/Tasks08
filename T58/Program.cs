//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int[,] CreatMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} | ");
        }
        Console.WriteLine();

    }
}
int[,] MultuMatrix(int[,] matr1, int[,] matr2)
{
    int c1 = matr1.GetLength(1);
    int r1 = matr1.GetLength(0);
    int c2 = matr2.GetLength(1);
    int[,] result = new int[c1, c2];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < c1; n++)
            {
                sum = matr1[i, n] * matr2[n, j] + sum;
            }
            result[i, j] = sum;
        }
    }
    return result;

}
Console.WriteLine("Введите размеры двух матриц.");
Console.WriteLine("Количество столбцов первой матрицы должно быть равно");
Console.Write("количеству строк второй матрицы. Число строк первой матрицы = ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов первой матрицы = ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число строк второй матрицы = ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов второй матрицы = ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижняя граница первой матрицы = ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница первой матрицы = ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижняя граница второй матрицы = ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница второй матрицы = ");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] matr1 = CreatMatrix(r1, c1, min1, max1);
int[,] matr2 = CreatMatrix(r2, c2, min2, max2);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
if (c1 != r2)
{

    Console.WriteLine("Неправильный ввод данных.");
    Console.WriteLine("Количество столбцов первой матрицы должно быть равно");
    Console.Write("количеству строк второй матрицы");

}
else
{
    int[,] matr3 = MultuMatrix(matr1, matr2);
    Console.WriteLine("Результирующая матрица");
    PrintMatrix(matr3);
}

