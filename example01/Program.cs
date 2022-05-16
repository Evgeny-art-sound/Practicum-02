// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели ");
int a = int.Parse(Console.ReadLine());
if (a>0 && a<=7)
{
	if (a==6^ a==7)
	{
		Console.WriteLine("Cегодня выходной! ");
	}
	else if (a!=6 && a!=7)
	{
		Console.WriteLine("Сегодня не выходной ");
	}
}
else Console.WriteLine("Неправильный номер дня недели ");