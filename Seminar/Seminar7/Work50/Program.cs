//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7->такого числа в массиве нет
//1, 2 -> 2

using System.Collections;

int[,] arr = new int[3, 4];
int[,] pos = new int[1, 2];

void InitArray(int[,] tmp_arr){
	for (int i = 0; i < tmp_arr.GetLength(0); i++){
		for (int k = 0; k < tmp_arr.GetLength(1); k++){
			tmp_arr[i, k] = Random.Shared.Next(0, 999);
		}
	}
}

int FindElement(int[,] tmp_arr, int[,] pos) {

	if (tmp_arr.GetLength(0) > pos[0, 0] && tmp_arr.GetLength(1) > pos[0, 1])
	{
		return tmp_arr[pos[0, 0], pos[0, 1]];
	}
	else {
		return -1;
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

InitArray(arr);
PrintArray(arr);
Console.Write("Введите номер строки: ");
Int32.TryParse(Console.ReadLine(), out pos[0, 0]);

Console.Write("Введите номер столбца: ");
Int32.TryParse(Console.ReadLine(), out pos[0, 1]);

int tmp_var = -1;
if ((tmp_var = FindElement(arr, pos)) >= 0)
{
    Console.WriteLine($"Число по индексу {pos[0, 0]}, {pos[0, 1]} = {tmp_var}");
}
else {
    Console.WriteLine("Такого числа нет.");
}