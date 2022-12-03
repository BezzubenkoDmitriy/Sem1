string? inputLine = Console.ReadLine();

if(inputLine!=null)
{
int inputNumber = int.Parse(inputLine);
int lastDigital = inputNumber % 10;
Console.WriteLine(lastDigital);

}