//Найти кубы чисел от 1 до N

void metod (int n)
{
int i=1;
while (i<n+1)
{
    Console.WriteLine($"{i} - {i*i*i} ");
    i++;
}
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
metod(a);
