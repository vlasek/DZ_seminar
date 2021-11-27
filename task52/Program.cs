//52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
            Console.Write($"{a[i, j],6}");
        }
        Console.WriteLine();
    }
}

void Task52(int[,] a)
{

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            //if (i % 2 == 0 && j % 2 == 0) { a[i, j] = Math.Pow(a[i, j],2); чего-то не хочет ^2}
            if (i % 2 == 0 && j % 2 == 0) { a[i, j] = a[i, j]*a[i,j]; }
        }
    }
}

int m = 10;
int n = 5;
int[,] a;
a = new int[m, n];

SetArray2D(a);
Print(a);
Task52(a);
Console.WriteLine();
Print(a);



