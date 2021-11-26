//45. Показать числа Фибоначчи

int Fibonachi()
{
    int f=0, f1=1;
    for (int i =0; i<45; i++)
    {
    f=f+f1;
    Console.Write($"{f} ");
    f1=f-f1;
    }
    return f;
}

Console.WriteLine(Fibonachi());

/*int Fib(int n) 
{
    if (n==0) return 0; 
    if (n==1 || n==2) return 1;
    else return Fib(n-1)+Fib(n-2);
}
Console.WriteLine(Fib(6));*/