// 54. отсортировать каждую строчку массива

using System;
using System.Collections;
using System.Collections.Generic;

int[,] arr = new int[4, 7];
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


// Сортировка слиянием
void MoveElements(int[,] array, int numRow, int start, int stop)
{
    int count = stop - start;
    int midle = (stop + start) / 2;
    int tmp_left = start;
    int tmp_right = midle + 1;

    int[] tmp_arr = new int[count + 1];

    for (int i = 0; i <= count; ++i)
    {
        if (tmp_left <= midle && (tmp_right > stop || array[numRow, tmp_left] > array[numRow, tmp_right]) )
        {
            tmp_arr[i] = array[numRow, tmp_left++];
        }
        else
        {
            tmp_arr[i] = array[numRow, tmp_right++];
        }
    }

    for (int i = 0; i <= count; ++i)
    {
        array[numRow, start + i] = tmp_arr[i];
    }
}

void SortRow(int [,] array, int numRow, int start, int stop) {

    int midle = (start + stop) / 2;
    if (start < stop) {
        SortRow(array, numRow, start, midle);
        SortRow(array, numRow, midle + 1, stop);
        MoveElements(array, numRow, start, stop);
    }
}


// Основной цикл программы
InitArray(arr);

Console.WriteLine("Начальный массив:");
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); ++i) {
    SortRow(arr, i, 0, arr.GetLength(1) - 1);
}

Console.WriteLine("Отсортированный массив:");
PrintArray(arr);