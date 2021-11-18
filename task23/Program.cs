// 23. Показать таблицу квадратов чисел от 1 до N 

void metod (int n)
{
int i=1;
while (i<n+1)
{
    Console.WriteLine($"{i} - {Math.Pow(i,2)} ");
    i++;
}
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
metod(a);