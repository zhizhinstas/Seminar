// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int row = 3;
int col = 3;
int deb = 3;

int[,,] arr1 = new int[deb, row, col];


void InitArray(int[,,] tmp_arr)
{
    for (int p = 0; p < tmp_arr.GetLength(0); p++)
    {
        for (int i = 0; i < tmp_arr.GetLength(1); i++)
        {
            for (int k = 0; k < tmp_arr.GetLength(2); k++)
            {
                tmp_arr[p, i, k] = Random.Shared.Next(1, 10);
            }
        }
    }
}

void PrintArray(int[,,] tmp_arr)
{
    for (int p = 0; p < tmp_arr.GetLength(0); p++)
    {
        for (int i = 0; i < tmp_arr.GetLength(0); i++)
        {
            for (int k = 0; k < tmp_arr.GetLength(1); k++)
            {
                Console.Write($"{tmp_arr[p, i, k]} ({p},{i},{k}) " );
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

InitArray(arr1);
PrintArray(arr1);