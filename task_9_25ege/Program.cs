﻿// Напишите программу, которая ищет среди целых чисел, принадлежащих числовому 
// отрезку [210 235; 210 300], числа, имеющие ровно четыре различных натуральных 
// делителя, не считая единицы и самого числа. Для каждого найденного числа 
// запишите эти четыре делителя в четыре соседних столбца на экране с новой 
// строки. Делители в строке должны следовать в порядке возрастания.
// Например, в диапазоне [10; 16] ровно четыре различных натуральных делителя 
// имеет число 12, поэтому для этого диапазона вывод на экране должна содержать 
// следующие значения: 2 3 4 6

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}

int [] A = new int [26];
A[0]=210;
void FillArray (int [] array)
{
    for (int i = 1; i < 26; i++)
    {
   A[i]=A[i-1]+1; 
    }
}
FillArray(A);
Console.WriteLine("Печать массива: ");
PrintArray(A);

// int i=0;
// int sum=0;


//void CheckArray(int [] array)
// {
//     //int sum=0;
//     for (i = 0; i < 26; i++)
//     {
//         for (int j=2; j<A[j]; j++)
//         {
//             if (A[i]%A[j]==0) {Console.WriteLine(j);
//             sum++;}
//         }
//     }
// }

//CheckArray(A);
//Console.WriteLine(sum);
// for (int i=210; i<=235; i++)
// {
//     if (i)
// }

// i=0;
// for (i=0; i<26; i++)
// {
//     for (int j=1; j<26; j++)
//     {
//     if (A[i]%A[j]==0) Console.WriteLine(A[j]);
//     }
// }



//решение на паскале
// var 
//     numDel, i, j: longint;
//     d: array[1..4] of longint;
// begin
//     for i := 210235 to 210300 do begin
//         numDel := 0;
//         for j := 2 to (i div 2) do begin
//             if i mod j = 0 then begin
//                 numDel := numDel + 1;
//                 if numDel > 4 then break;
//                 d[numDel] := j;
//             end;
//         end;
//         if numDel = 4 then writeln(d[1], ' ', d[2], ' ', d[3], ' ', d[4]);
//     end;
// end.


int numDel, j;
i=0;
int [] d =  new int {1, 2, 3, 4} ;


 for (int i = 210235; i<210300; i++)
 { numDel = 0;
    for (int j = 2; j< (i/2); j++)
    { if (i % j == 0) 
        { numDel = numDel + 1;
        if (numDel > 4)  break;
        d[numDel] = j;
        };
    }
        if (numDel == 4)  Console.WriteLine($"{d[1]},  {d[2]},  {d[3]}, {d[4]}"); 
 };
 }
 
 