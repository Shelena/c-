Console.WriteLine("Введите координаты точки a");
Console.Write("x:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки b");
Console.Write("x:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z:");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
Console.Write("Расстояние между точками:");
Console.WriteLine(result);


