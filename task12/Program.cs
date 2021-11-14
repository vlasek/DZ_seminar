// 12. Удалить вторую цифру трёхзначного числа

string Delete2Number (int n)
{

    return $"{n/100}-{n%10}";
}

int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Delete2Number(a));
