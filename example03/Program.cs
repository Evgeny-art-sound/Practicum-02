// // Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти координат ");
int a = int.Parse(Console.ReadLine());
if (a > 0 && a < 5)
{
	Console.WriteLine("Возможные координаты: ");
	if (a == 1)
	{
		Console.WriteLine("X от 0 до бесконечности ");
		Console.WriteLine("Y от 0 до бесконечности ");
	}
	else if (a == 2)
	{
		Console.WriteLine("X от минус бесконечности до 0 ");
		Console.WriteLine("Y от 0 до бесконечности ");
	}
	else if (a == 3)
	{
		Console.WriteLine("X от минус бесконечности до 0 ");
		Console.WriteLine("Y от минус бесконечности до 0 ");
	}
	else if (a == 4)
	{
		Console.WriteLine("X от 0 до бесконечности ");
		Console.WriteLine("Y от минус бесконечности до 0");
	}

}
else Console.WriteLine("Неправильный номер четверти!");