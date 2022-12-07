
int numberDay = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(numberDay);

if(numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("Это не является днем недели");
}
if(numberDay==6||numberDay==7)
{
    Console.WriteLine("Этот день является выходным");
}
if(numberDay<6)
{
    Console.WriteLine("Работай!!!");
}

