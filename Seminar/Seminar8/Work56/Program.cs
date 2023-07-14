//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] arr = new int[6, 4];

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
int GetSumElementRow(int[,] arr, int row){
    int out_sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++) {
        out_sum += arr[row, i];
    }
    return out_sum;
}

int GetMinimalSumRow(int[,] arr) {
    int tmp_sum = int.MaxValue, tmp_current_sum = int.MaxValue, out_row = -1;

    for (int i = 0; i < arr.GetLength(0); i++) {
        tmp_current_sum = GetSumElementRow(arr, i);
        if (tmp_current_sum < tmp_sum) {
            tmp_sum = tmp_current_sum;
            out_row = i;
        }
    }

    return out_row;
}

InitArray(arr);
PrintArray(arr);

Console.WriteLine($"Строка с наименьшей суммой: {GetMinimalSumRow(arr)}");