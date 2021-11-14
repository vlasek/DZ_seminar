// 28. Подсчитать сумму цифр в числе

int A (int b)
{
  int sum=0;
  while (b>0)
  {
      sum+=b%10;
      b=b/10;
  }  
  return sum;
}
Console.WriteLine (A(12443534));
