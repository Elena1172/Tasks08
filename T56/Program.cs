//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка
int[,] CreatMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max);
        }
    }

    return matrix;
}
int[] SumRows(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        array[i] = sum;
    }
    return array;
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
int MinItemNumber(int[]array){
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min){
            min = array[i];
            index = i;
        } 
    }
    return index + 1;

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
int[] ar = SumRows(newmatrix);
int num = MinItemNumber(ar);
Console.WriteLine($"Наименьшая сумма элементов в заданном массиве: {num} строка");
