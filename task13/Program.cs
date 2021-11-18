// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a=new Random().Next(0,100);
Console.WriteLine (" Введите чему должно быть кратно число: ")ж
int b=Convert.ToInt32(Console.ReadLine());

string Delete2Number (int n)
{

    return $"{n/100}-{n%10}";
    //return 10*(n)/100+n%10; проверить 
    //Matn.Abs (number)' // модуль числа
}

int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Delete2Number(a));