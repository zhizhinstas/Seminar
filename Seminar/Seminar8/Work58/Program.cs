// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int row = 3;
int col = 3;

int[,] arr1 = new int[row, col];
int[,] arr2 = new int[row, col];
//int[,] arr_new = new int[row, col];

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

int[,] ArrayMultiplie(int[,] arr_first, int[,] arr_second) {
    int[,] out_arr = new int[row, col];

    for (int i = 0; i < arr_first.GetLength(0); i++) {
        for (int k = 0; k < arr_first.GetLength(1); k++) {
            out_arr[i, k] = arr_first[i, k] * arr_second[i, k];
        }
    }
    return out_arr;

}

InitArray(arr1);
InitArray(arr2);

PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
PrintArray(ArrayMultiplie(arr1, arr2));

