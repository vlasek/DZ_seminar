//29. Написать программу вычисления произведения чисел от 1 до N

void metod (int n)
{
int i=1;
int b=1;
while (i<n+1)
{
    
    b=b*i;
    i++;
}
Console.WriteLine("произведение чисел " + b);
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
metod(a);