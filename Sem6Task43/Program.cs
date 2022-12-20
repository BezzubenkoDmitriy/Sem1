// Ввод данных 
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
//нахождение точки пересечения координат 
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
//Вывод данных в консоле
Console.WriteLine($"точка пересечения X: {x}, Y: {y}");
