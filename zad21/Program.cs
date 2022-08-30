double x1, x2, y1, y2, z1, z2;
Console.WriteLine("Введите первую координату первой точки");
x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату второй точки");
x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки");
y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки");
y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату первой точки");
z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третьюю координату второй точки");
z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine(result);