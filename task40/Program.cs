// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int GetRandom ()
{
  return new Random().Next(1,100);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}
int min, max;
int dif1=0;
int FoundDifMaxMin(int [] array)
{
    max=0; min=100;
    for (int i = 0; i < array.Length; i++)
    {if (array[i]>max) max=array[i];
     else {if (array[i]<min )  min=array[i];}}

    dif1=max-min;
    return dif1;
}

int i=0;
int [] A= new int [20];
while (i<20)
{ A[i]=GetRandom(); i++; }



PrintArray(A);
FoundDifMaxMin(A);
Console.WriteLine ($"Разница между максимальным и минимальным элеметов = {(FoundDifMaxMin(A))} max ={max} min={min}");

