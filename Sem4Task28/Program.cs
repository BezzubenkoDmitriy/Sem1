
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData(string res)
{
    Console.WriteLine(res);
}
long CalcFactor(int num)
{
    long count = 1;
    for(int i=1;i<=num;i++)
    {
        count *=i;
    }
    return count;
}
int number = ReadData("Введите число А");
long lenght1 = CalcFactor(number);
PrintData("Факториал равно"+lenght1);