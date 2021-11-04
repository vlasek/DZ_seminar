//По двум заданным числам проверять является ли 
//первое квадратом второго

int a, b;
Console.WriteLine ("Введите первое число");
a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите второе число");
b = Convert.ToInt32(Console.ReadLine ());
if (Math.Pow(b,2) == a) Console.WriteLine ("Да первое число квадрат второго");
else Console.WriteLine ("НЕТ, первое число не квадрат второго");


Console.WriteLine (Math.Pow(b,2)); // для проверки
