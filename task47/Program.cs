// 47. Написать программу копирования массива

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

int[] B = new int [20];
int[] A = new int [20];
void CopyArray (int [] array)
{
    for (int i = 0; i < 20; i++)
    {
        B[i]= A[i]+1; //сделал плюс один чтобы видно было
    }  
}

int i=0;

while (i<20)
{ A[i]=GetRandom(); i++; }

Console.WriteLine("Массив из 20 элементов прямой и и его копия сделал плюс 1");
PrintArray (A);
CopyArray (A); 
PrintArray(B);
