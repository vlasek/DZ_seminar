﻿//45. Показать числа Фибоначчи

int Fibonachi()
{
    int f=0, f1=1;
    for (int i =0; i<40; i++)
    {
    f=f+f1;
    Console.Write($"{f} ");
    f1=f-f1;
    }
    return f;
}

Console.WriteLine(Fibonachi());