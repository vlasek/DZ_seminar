//45. Показать числа Фибоначчи

int Fibonachi()
{
    int f=1, s=0;
    for (int i =0; i<40; i++)
    {
    f=f+s;
    s=f;
    Console.WriteLine(f);
    }
    return f;
}
Console.WriteLine(Fibonachi());