//49. Показать двумерный массив размером m×n заполненный вещественными числами
// тчто-то не так
void SetArray2D(double [,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=new Random().Next(0,10);
        }
    }
}

void Print(double [,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}


int m=10;
int n=5;
double [,] a;
a=new double [m,n];

SetArray2D(a);
Print(a);

