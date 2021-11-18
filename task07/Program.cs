//Показать числа от -N до N

int a;
Console.WriteLine ("Введите число N");
a = Convert.ToInt32(Console.ReadLine ());

if (a<0) a=-a;
for (int i=-a; i<=a; i++)
{
  Console.Write ($"{i},");
}

//Показать числа от -N до N

void metod (int n)
{
int count = -n;
while (count< n+1)
{
    Console.Write($"{count} ");
    count++;
}
}
Console.WriteLine("Введите число ");
int b = Convert.ToInt32(Console.ReadLine());
metod(b);
