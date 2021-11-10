//Показать числа от -N до N

void met (int n)
{
int count = -n;
while (count< n+1)
{
    Console.Write($"{count} ");
    count++;
}
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
met(a);