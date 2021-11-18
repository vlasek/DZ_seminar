// 34. Написать программу замену элементов массива на противоположные

int GetRandom ()
{
  return new Random().Next(1,100);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < 8; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}

int[] B = new int [8];
int[] A = new int [8];
int length=7;
void ChangeSign (int [] array)
{
    for (int i = 0; i < 8; i++)
    {
        B[i]= A[length-i];
    }
    
}

int i=0;

while (i<8)
{ A[i]=GetRandom(); i++; }

Console.WriteLine("Массив из 8 элементов прямой и потом реверсивный");
PrintArray (A);
ChangeSign (A); 
PrintArray(B);