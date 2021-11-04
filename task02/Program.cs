//Даны два числа. Показать большее и меньшее число
int a, b;
Console.WriteLine ("Введите первое число");
a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите второе число");
b = Convert.ToInt32(Console.ReadLine ());
if (a<b) Console.WriteLine ("Первое меньше второго");
else Console.WriteLine ("Второе больше первого");