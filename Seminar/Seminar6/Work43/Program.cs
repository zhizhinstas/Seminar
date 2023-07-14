//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



while (true)
{
	int len_arr = 0;
    int k1 = 0, b1 = 0, k2 = 0, b2 = 0;
    Console.WriteLine("Задайте коэффициенты для уравнений y = k1 * x + b1, y = k2 * x + b2:");
    Console.WriteLine("Порядок k1, k2, b1, b2 (0 для выхода)");
	for (int i = 0; i < 4; i++) {
		int tmp;
        Int32.TryParse(Console.ReadLine(), out tmp);

		switch (i)
		{
			case 0: k1 = tmp; break;
			case 1: k2 = tmp; break;
			case 2: b1 = tmp; break;
			case 3: b2 = tmp; break;
		}
    }

    // Условие выхода
    if (k1 == 0 || b1 == 0 || k2 == 0 || b2 == 0) { break; }

    float x, y;

	x = (float)(b2 - b1) / (k1 - k2);
	y = (float)(k1 * x + b1);

    Console.WriteLine($"Линии пересекутся в точке {x}, {y}.");
}
