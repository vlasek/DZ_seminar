//вывести на экран число от 1 до 10 не использую цикла и оператора goto

void Loop(int i)
{
    Console.Write($"{i} ");
    if (i<10) Loop(i+1);
}
Loop (5);

decimal F(decimal n) //factorial или тип decimal
{
    if (n==0) return 1;
    else return F(n-1)*n;
}
Console.WriteLine(F(5));