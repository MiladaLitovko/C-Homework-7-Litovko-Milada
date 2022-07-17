/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Zadacha52();

void Zadacha52()
{
    Random random = new Random();
    Console.WriteLine("Введите кол-во столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    ArithmeticMeanRows(array);

    void ArithmeticMeanRows(int[,] array)
    {
        Console.Write("Среднее арифметическое каждого столбца: ");
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            double arithmeticMean = 0;
            for (int i = 0; i < rows; i++)
            {
                sum = sum + array[i, j];
            }
            arithmeticMean = (double)sum / rows;
            Console.Write(Math.Round(arithmeticMean, 1) + (j + 1 != columns ?  "; " : "."));
        }
    }


    void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(-10, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }






}