
string? numLine = Console.ReadLine();

if(numLine != null)
{
    int num = int.Parse(numLine);
    
    if(num % 2 == 0)
    {
        Console.WriteLine("число является четным"); 
    }
    else 
    {
        Console.WriteLine("число является нечетным");
    }

}

