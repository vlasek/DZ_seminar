//27. Определить количество цифр в числе
// 4567 - 4 цифры

int CountDigit (int n)
{
    int k=0;
    while (n!=0)
    {
    k++;
    n=n/10;
    }
    return k;
}
Console.WriteLine(CountDigit(234));

void Pause()
{
    Console.ReadKey();
}
Pause();