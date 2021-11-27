// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

void Task55(int[,] a)
{
   
    for (int j = 0; j < a.GetLength(0); j++)
    {
        int sum=0;
        for (int i = 0; i < a.GetLength(1); i++)
        {
         {sum=sum+a[i,j]; Console.Write($"{a[i,j]} + " );}
            
        }
        System.Console.WriteLine($" = {sum}");
    }

}

int m = 10;
int n = 10;
int[,] a;
a = new int[m, n];

SetArray2D(a);
Print(a);
Task55(a);


