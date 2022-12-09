
int x1 = ReadData("Введите координату X1");
int x2 = ReadData("Введите координату X2");
int y1 = ReadData("Введите координату y1");
int y2 = ReadData("Введите координату y2");
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
double CalculateLenght(int x1,int x2,int y1,int y2)
{
    double res = 0;
    res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return res;


}
void PrintData(string message,double res)
{
    Console.WriteLine(message+res);

}
PrintData("Расстояние между точками равно",CalculateLenght(x1,y1,x2,y2));

