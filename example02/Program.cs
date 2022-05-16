// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое чило ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if (b * b == a)
{
	Console.WriteLine("Первое чило квадрат второго ");
}
else if (a * a == b)
{
	Console.WriteLine("Второе число квадрат первого ");
}
else Console.WriteLine("Числа не являются квадратами друг-друга");