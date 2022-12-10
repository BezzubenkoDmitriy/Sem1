


int x1 = ReadData ("x", "A");
int y1 = ReadData ("y", "A");
int z1 = ReadData ("z", "A");
int x2 = ReadData ("x", "B");
int y2 = ReadData ("y", "B");
int z2 = ReadData ("z", "B");
int ReadData(string coorName, string pointName)
{
    Console.WriteLine($"Введите координату {coorName} точки {pointName}: ");
    return int.Parse(Console.ReadLine()??"0");
}
double Decision(double x1, double x2, double y1, double y2,  double z1, double z2)
        
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));  
}   
                   

double digLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {digLength}");
