
int number = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(number);

int result = ((number%100)%10);


if(number<100)
{
    Console.WriteLine("Число не является трехзначным");
}
if(number>99)
{
    Console.WriteLine(result);
}





