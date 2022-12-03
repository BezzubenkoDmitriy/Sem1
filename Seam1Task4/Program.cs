// Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();
// Проверяем что бы данные не были пустыми
if(num1Line != null && num2Line != null && num3Line !=null )
{
    //Парсим введеные числа
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

// Сравниваю числа 
    if(num1>num2)
    {
        if(num1>num3)
        {
           Console.WriteLine(num1Line);
        }

        else
        {
            Console.WriteLine(num3Line);
    
        }
    }

    else
    {
        if(num2>num3)
        {
            Console.WriteLine(num2Line);
        }

        else
        {
            Console.WriteLine(num3Line);
        }
    }
}
    










                                 