//Написать программу вычисления значения функции y=f(a)

int Function(int x)
{
    int y = x * x ;
    return y;
}
Console.WriteLine("Введите число перменную х: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш ответ"  + Function(a));
