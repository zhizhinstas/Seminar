//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Программа определяет большее и меньшее. (для выхода введите '0' 2 раза)");
Console.WriteLine("Введите 2 числа: ");

int num1 = 0, num2 = 0;

while (true)
{
	// Получение чисел и попытка преобразования
	if (!Int32.TryParse(Console.ReadLine(), out num1) || !Int32.TryParse(Console.ReadLine(), out num2)) { 
		Console.WriteLine("Не число!"); continue; 
	}

	// Условие выхода
	if (num1 == 0 && num2 == 0) { break; }

	// Сравнение и вывод в консоль.
	if (num1 == num2)       { Console.WriteLine($"num1 = {num1}, num2 = {num2}, они равны!"); }
	else if (num1 > num2)   { Console.WriteLine($"num1 = {num1}, num2 = {num2}, max = {num1}, min = {num2}"); }
	else                    { Console.WriteLine($"num1 = {num1}, num2 = {num2}, max = {num2}, min = {num1}"); }

}