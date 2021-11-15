//29. Написать программу вычисления произведения чисел от 1 до N
// лимит до 20 потом переполнение и можно исплользовать long ulong double тип
void metod (int n)
{
int i=1;
long F=1; //ulong 64 bit long 64
while (i<n+1)
{
    F=F*i;  //F=F*(uint)i приведение типов
    i++;
}
Console.WriteLine("произведение чисел " + F);
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
metod(a);