//Показать числа от -N до N


int a;
Console.WriteLine ("Введите число N");
a = Convert.ToInt32(Console.ReadLine ());

if (a<0) a=-a;
for (int i=-a; i<=a; i++)
{
  Console.Write ($"{i},");
}


