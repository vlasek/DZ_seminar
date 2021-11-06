//Задать массив из 8 элементов и вывести их на экран 


int GetRandom ()
{
  return new Random().Next(0,100);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < 8; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}
int i=0;
int[] A = new int [8];
while (i<8)
{ A[i]=GetRandom(); i++; }



Console.WriteLine("Массив из 8 элементов");
PrintArray (A);