// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] arr = new int[4, 4];

void SpiralInitArray(int[,] tmp_arr)
{
    int num = 1;
    int size = tmp_arr.GetLength(0);
    for (int i = size - 1, j = 0; i > 0; i--, j++)
    {
        for (int k = j; k < i; k++) { tmp_arr[j, k] = num++; }
        for (int k = j; k < i; k++) { tmp_arr[k, i] = num++; }
        for (int k = i; k > j; k--) { tmp_arr[i, k] = num++; }
        for (int k = i; k > j; k--) { tmp_arr[k, j] = num++; }
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

SpiralInitArray(arr);
PrintArray(arr);