// Возведите число А в натуральную степень B используя цикл

int a, b, c=1;
Console.WriteLine ("Введите число А");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите степень Б");
b=Convert.ToInt32(Console.ReadLine());


for (int i=0; i<b; i++)
{
    c=c*a;
}

Console.WriteLine(c);

