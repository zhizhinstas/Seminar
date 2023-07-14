//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] my_arr = new int[8];
void InitArrayRec(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Random.Shared.Next(1000);
    }
}

void PrintArrayRec(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + ", ");
    }
}

InitArrayRec(my_arr);
PrintArrayRec(my_arr);







//// Глобальные функции! Видны везде, но сейчас тут мусор. 
//// Кроме result потому что я явно указал чему она равна (нужно будет в дальнейшем)
//int A, B, result = 1;

//// Вот это функция чтобы их заполнить! Но она еще не работает.
//void fun() {
//    Console.WriteLine("Введите А");
//    A = Int32.Parse(Console.ReadLine()); // Вот тут А таже, что и снаружи в 25 строке!!!

//    Console.WriteLine("Введите B");
//    B = Int32.Parse(Console.ReadLine());// Вот тут B таже, что и снаружи в 25 строке!!!
//}

//// Вот тут мы вызыаем функцию, чтобы она заработала
//fun();

//// Вот в этом месте программы
//// переменные A и B будут иметь данные которые ты введешь когда будет работать функция
//// Делаем цикл
//for (int i = 0; i < B; i++) {
//    result *= A; // Вот тут как раз пригодилось сразу указание result = 1; Иначе будет ошибка
//}

//// И последний вывод...
//Console.WriteLine("result = " + result);