/*Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Zadacha50();

void Zadacha50()
{
    Random random = new Random();
    Console.WriteLine("Введите кол-во столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    FindElement(array);

    void FindElement(int[,] array)
    {
        Console.WriteLine("Введите позицию элемента в массиве по столбцу");
        int PositionColumn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите позицию элемента в массиве по строке");
        int PositionRow = Convert.ToInt32(Console.ReadLine());

        if(PositionRow <= rows || PositionColumn <= columns)
        {
            Console.WriteLine($"Значение элемента по столбцу {PositionColumn} и строке {PositionRow} равно: {array[PositionRow - 1, PositionColumn - 1]}");
        }
        else
        {
            Console.WriteLine("такого числа в массиве нет");
        }
    }


    void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(-10, 10);
            }
        }
    }

    void PrintArray(int[,] array)
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