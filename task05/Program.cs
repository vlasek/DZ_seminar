//Написать программу вычисления значения функции y=f(a)

int Function(int a)
{
    int y = a * a ;
    return y; // можно просто return a*a
}
Console.WriteLine("Введите число перменную a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш ответ"  + Function(a));
