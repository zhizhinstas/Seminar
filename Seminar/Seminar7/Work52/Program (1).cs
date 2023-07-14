//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

int[,] arr = new int[3, 4];

void InitArray(int[,] tmp_arr)
{
    for (int i = 0; i < tmp_arr.GetLength(0); i++)
    {
        for (int k = 0; k < tmp_arr.GetLength(1); k++)
        {
            tmp_arr[i, k] = Random.Shared.Next(1, 10);
        }
    }
}

void PrintArray(int[,] tmp_arr)
{
    for (int i = 0; i < tmp_arr.GetLength(0); i++)
    {
        for (int k = 0; k < tmp_arr.GetLength(1); k++)
        {
            Console.Write(tmp_arr[i, k] + "  ");
        }
        Console.WriteLine();
    }
}

void AverageRow(int[,] tmp_arr) {

    for (int row = 0; row < tmp_arr.GetLength(1); row++)
    {
        double tmp = 0;
        for (int lane = 0; lane < tmp_arr.GetLength(0); lane++)
        {
            tmp += tmp_arr[lane, row];
        }
        Console.WriteLine($"Среднее арифметическое столбца {row + 1} = {Math.Round(tmp / tmp_arr.GetLength(0), 1)}");
    }
}

InitArray(arr);
PrintArray(arr);
AverageRow(arr);