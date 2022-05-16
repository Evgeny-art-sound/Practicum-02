// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое чиcло ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if (b * b == a)
{
	Console.WriteLine("Первое чиcло квадрат второго ");
}
else if (a * a == b)
{
	Console.WriteLine("Второе число квадрат первого ");
}
else Console.WriteLine("Одно число не квадрат второго ");
