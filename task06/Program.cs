//Выяснить является ли число чётным
int a;
Console.WriteLine ("Введите число. Я провербю четное оно или нет?");
a = Convert.ToInt32(Console.ReadLine ());
if (a%2 == 0) Console.WriteLine ("Число четное");
else Console.WriteLine("Число нечетное");