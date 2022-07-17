/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
округлёнными до одного знака.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Zadacha47();

void Zadacha47()
{
    Random random = new Random();
    Console.WriteLine("Введите кол-во столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    FillArray(array);

    PrintArray(array);

    void FillArray(double[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
            }
        }
    }

    void PrintArray(double[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }






}
