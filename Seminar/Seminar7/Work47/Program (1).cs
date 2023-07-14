//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] arr = new double[3, 4];

void InitArray(double[,] tmp_arr) 
{
	for (int i = 0; i < tmp_arr.GetLength(0); i++){
		for (int k = 0; k < tmp_arr.GetLength(1); k++){
			tmp_arr[i, k] = Math.Round((Random.Shared.Next(-999, 999) *0.01), 2);
		}
	}
}

void PrintArray(double[,] tmp_arr) {
	for (int i = 0; i < tmp_arr.GetLength(0); i++){
		for (int k = 0; k < tmp_arr.GetLength(1); k++){
			Console.Write(tmp_arr[i, k] + "  ");
		}
		Console.WriteLine();
	}
}

InitArray(arr);
PrintArray(arr);