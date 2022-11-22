//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
int[,,] Creat3D(int rows, int columns, int depth)
{
    Random rn = new Random((int)(DateTime.Now.Ticks));
    int[,,] matr = new int[rows, columns, depth];
    for (int i = 0; i < matr.GetLongLength(0); i++)
    {

        for (int j = 0; j < matr.GetLongLength(1); j++)
        {

            for (int k = 0; k < matr.GetLongLength(2); k++)
            {
                int n = rn.Next(10, 100);

                matr[i, j, k] = n;

            }
        }
    }
    return matr;
}
void Print3D(int[,,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                Console.Write($"{mat[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}
Console.Write("Задайте размеры трехмерного массива.Число строк = ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Глубина массива = ");
int d = Convert.ToInt32(Console.ReadLine());
if (r < 1 || c < 1 || d < 1) Console.Write("Размер массива задается натуральными числами кроме 0");
else
{
    int[,,] newmatrix = Creat3D(r, c, d);

    Print3D(newmatrix);
}