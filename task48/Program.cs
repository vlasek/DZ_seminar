// 48. Показать двумерный массив размером m×n заполненный целыми числами

void SetArray2D(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=new Random().Next(1,100);
        }
    }
}

void Print(int[,] a)
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
int[,] a;
a=new int[m,n];

SetArray2D(a);
Print(a);


 