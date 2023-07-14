//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int counter = 0;
int[] ints;

void ErnterNumb()
{
    int tmp_var = 0;
	Int32.TryParse(Console.ReadLine(), out tmp_var);
    if (tmp_var > 0) { ++counter; } 
}

while (true) {

    int len_arr = 0;
    Console.WriteLine("Введите размер массива: (0 для выхода)");
	Int32.TryParse(Console.ReadLine(), out len_arr);

	// Условие выхода
	if (len_arr <= 0) {  break; }

    if (len_arr > 0) { ints = new int[len_arr]; }
	for (int i = 0; i < len_arr; i++) {
        Console.Write($"Введите число {i+1}: ");
        ErnterNumb();
    }
	
    Console.WriteLine($"Положительных {counter}.");
}
