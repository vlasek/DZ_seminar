// 12. Удалить вторую цифру трёхзначного числа

string Delete2Number (int n)
{

    return $"{n/100}-{n%10}";
    //return 10*(n)/100+n%10; проверить 
    //Matn.Abs (number)' // модуль числа
}

int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Delete2Number(a));
