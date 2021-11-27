// 56. Написать программу, которая обменивает элементы первой строки и последней строки

void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(1, 20);
        }
    }
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}

void Task56(int[,] a)
{
    int tmp;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i==0 || i==3)
            {
            tmp=a[i,j];
            a[i,j]=a[i,j];
            a[i,j]=tmp;
            }
    }
    }
}

int m = 4;
int n = 4;
int[,] a;
a = new int[m, n];

SetArray2D(a);
Print(a);
Task56(a);

System.Console.WriteLine();
Print(a);




