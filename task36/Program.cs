//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


int GetRandom ()
{
  return new Random().Next(100,1000);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}

int i=0;
int[] A = new int [20];
while (i<20)
{ A[i]=GetRandom(); i++; }

Console.WriteLine("Массив из 20 элементов");
PrintArray (A);
int nechet=0, chet=0;

for (int j = 0; j < 20; j++)
{
    if (A[j]%2==0) chet=chet+1;
    else nechet=nechet+1;
}
Console.WriteLine($"В массиве {nechet} нечетных элемпентов и {chet} четных элемента");