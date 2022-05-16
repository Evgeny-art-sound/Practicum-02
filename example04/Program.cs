// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите количество плоскостей для расчета 2 или 3? ");
int d = int.Parse(Console.ReadLine());
if (d == 2)
{
	Console.Write("Введите координату X точки А ");
	int ax = int.Parse(Console.ReadLine());
	Console.Write("Введите координату Y точки А ");
	int ay = int.Parse(Console.ReadLine());
	Console.Write("Введите координату X точки B ");
	int bx = int.Parse(Console.ReadLine());
	Console.Write("Введите координату Y точки B ");
	int by = int.Parse(Console.ReadLine());
	Console.Write("Расстояние между точками А и B = ");
	Console.Write(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)));
}
else if (d == 3)
{
	Console.Write("Введите координату X точки А ");
	int ax = int.Parse(Console.ReadLine());
	Console.Write("Введите координату Y точки А ");
	int ay = int.Parse(Console.ReadLine());
	Console.Write("Введите координату Z точки А ");
	int az = int.Parse(Console.ReadLine());
	Console.Write("Введите координату X точки B ");
	int bx = int.Parse(Console.ReadLine());
	Console.Write("Введите координату Y точки B ");
	int by = int.Parse(Console.ReadLine());
	Console.Write("Введите координату Z точки B ");
	int bz = int.Parse(Console.ReadLine());

	Console.Write("Расстояние между точками А и B = ");
	Console.Write(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)));
}
else Console.WriteLine("Число плоскостей может быть только 2 или 3 !");