//Найти сумму чисел от 1 до А

void metod (int n)
{
int i=1;
int b=0;
while (i<n+1)
{
    
    b=b+i;
    i++;
}
Console.WriteLine("сумма чисел " + b);
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
metod(a);