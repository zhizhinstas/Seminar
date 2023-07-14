//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа определяет большее и меньшее. (для выхода введите '0' 3 раза)");
Console.WriteLine("Введите 3 числа:");

int[] num = new int[3];

bool GetNum() {	
	for (int i = 0; i < 3; i++){
		if (!Int32.TryParse(Console.ReadLine(), out num[i])){
			return false;
		}
	}
	return true;
}

while (true)
{
    // Получение и преобразование типов
    if (!GetNum()) { Console.WriteLine("Не число!"); continue; }

    // Условие выхода
    if (num[0] == 0 && num[1] == 0 && num[2] == 0) { break;} 

	// дополнительные переменные
	int max = num[0], min = num[0];
	string outStr = "";

	// Цикл нахождения максимального и минимального
	for (int i = 1; i < 3; i++) {
		if (min > num[i]) { min = num[i]; }
		if (max < num[i]) { max = num[i]; }
	}

	// Формирование строки
	for (int i = 0; i < 3; i++) { outStr += num[i] + ", "; }

	// Вывод в консоль.
	Console.WriteLine($"{outStr} max = {max}, min = {min}");
}

