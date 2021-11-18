// 43. Написать программу преобразования десятичного числа в двоичное


Console.Write("Введите число :");
int value = Convert.ToInt32(Console.ReadLine());
string BinaryCode = Convert.ToString(value, 2);
Console.WriteLine($"двоичный код : {BinaryCode}");


