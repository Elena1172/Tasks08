//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
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
void SortyRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }

            }

        }
    }
}
Console.Write("Задайте размеры двумерного массива. Число строк = ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижняя граница массива = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница массива = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] newmatrix = CreatMatrix(r, c, n, m);
PrintMatrix(newmatrix);
Console.WriteLine("Отсортированный по строкам (в порядке убывания) массив:");
SortyRows(newmatrix);
PrintMatrix(newmatrix);