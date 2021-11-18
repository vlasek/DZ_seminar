// 39. Найти произведение пар чисел в одномерном 
//массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д.

int GetRandom ()
{
  return new Random().Next(1,10);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}

int[] A = new int [20];
int[] B = new int [10];
//int proizv=1;
void Proizvedenie (int [] array)
{
    for (int i = 0; i <10; i++)
    {
        B[i]=A[i]*A[19-i];
        Console.WriteLine($"{A[i]} x {A[19-i]} = {B[i]}");
        // proizv=proizv*A[i]* A[20-i];
        // Console.WriteLine(proizv);

    }
    //return proizv;
}

int i=0;

while (i<20)
{ A[i]=GetRandom(); i++; }

Console.WriteLine("Массив A");
PrintArray (A);
Console.WriteLine("Массив B");
Proizvedenie(A); 
PrintArray(B);

//Console.WriteLine(proizv);
//(Proizvedenie(A)); 
