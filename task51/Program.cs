//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = i+j;
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


int m = 10;
int n = 5;
int[,] a;
a = new int[m, n];

SetArray2D(a);
Print(a);



