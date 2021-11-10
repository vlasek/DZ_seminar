//30. Показать кубы чисел, заканчивающихся на четную цифру//

void metod (int n)
{
int i=1;
while (i<n+1)
{
    if (i%2==0) Console.WriteLine($"{i} - {i*i*i} ");
    i++;
}
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
metod(a);