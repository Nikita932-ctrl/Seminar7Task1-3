//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int[,] FullArray(int m, int n)
{
    int[,] array = new int[m, n];


    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = random.Next(10);

        }

    }

    return array;
}

int[,] newArray = FullArray(4, 4);

for (int row = 0; row < newArray.GetLength(0); row++)
{
    for (int column = 0; column < newArray.GetLength(1); column++)
    {
        Console.Write(newArray[row, column] + "\t");
    }
    Console.WriteLine();
}
*/
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] FullArray(int m, int n)
{
    int[,] array = new int[m, n];


    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = random.Next(10);

        }

    }

    return array;
}

int[,] newArray = FullArray(4, 4);

for (int row = 0; row < newArray.GetLength(0); row++)
{
    for (int column = 0; column < newArray.GetLength(1); column++)
    {
        Console.Write(newArray[row, column] + "\t");
    }
    Console.WriteLine();
}



Console.WriteLine("Write row: ");
int raw = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write column: ");
int inputcolumn = Convert.ToInt32(Console.ReadLine());


if (raw > newArray.GetLength(0) || inputcolumn > newArray.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {raw} строки и {inputcolumn} столбца равно {newArray[raw - 1, inputcolumn - 1]}");
}

*/
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] FullArray(int m, int n)
{
    int[,] array = new int[m, n];


    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = random.Next(10);

        }

    }

    return array;
}

int[,] newArray = FullArray(4, 4);

for (int row = 0; row < newArray.GetLength(0); row++)
{
    for (int column = 0; column < newArray.GetLength(1); column++)
    {
        Console.Write(newArray[row, column] + "\t");
    }
    Console.WriteLine();
}


for (int i = 0; i < newArray.GetLength(0); i++) 
{
    double sum = 0;
    for (int j = 0; j < newArray.GetLength(1); j++) 
    {

        sum = sum + newArray[i, j];
        sum = sum / i;

    }
    sum = sum / i;
    Console.WriteLine(sum);
}


