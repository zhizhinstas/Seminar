int myFuncExponentRec(int num, int expo)
{
    if (expo == 1)
    {
        return num;
    }
    else
    {
        return num * myFuncExponentRec(num, expo - 1);
    }
}

float myFuncExponent(int num, int expo)
{
    if (expo == 0) { return 1; }

    float tmp_out = 1;
    if (expo > 0)
    {
        tmp_out = myFuncExponentRec(num, expo);
    }
    else
    {
        tmp_out /= myFuncExponentRec(num, expo * (-1));
    }
    return tmp_out;
}

int num, expo;
while (true)
{
    Console.WriteLine("Программа возводит первое число в степень второго (кроме дробных)");
    Console.WriteLine("Введите число (0 - для выхода):");
    Int32.TryParse(Console.ReadLine(), out num);

    if (num == 0) { break; }

    Console.WriteLine("Введите степень:");
    Int32.TryParse(Console.ReadLine(), out expo);


    Console.WriteLine($"Число {num} в степени {expo} = {myFuncExponent(num, expo)}");
}