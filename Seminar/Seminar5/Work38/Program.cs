//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76




double[] Arr;
double min = 0, max = 0;

int lenArr;
string str = "";

// Функция заполнение массива рандомными числами
void initArr(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Math.Round((Random.Shared.Next(1, 10000) * 0.01), 2);
        str += Arr[i].ToString() + ", ";
        if (min > Arr[i]) { min = Arr[i]; }
        if (max < Arr[i]) { max = Arr[i]; }
    }
    Console.WriteLine($"Исходный массив: {str}");
}


// Основная программа
while (true)
{
    // Ввод данных
    Console.WriteLine("Введите размер массива. (0 - для выхода)");
    if (!Int32.TryParse(Console.ReadLine(), out lenArr))
    {
        Console.WriteLine("Не число!");
        continue;
    }

    // Условие выхода
    if (lenArr == 0) { break; }

    // Выполнение условия задания
    Arr = new double[lenArr];
    initArr(Arr);

    // Вывод на экран
    Console.WriteLine($"Разница максимального и минимального числа: {max - min}");
}