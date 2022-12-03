// Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
// Проверяем что бы данные не были пустыми
if(num1Line != null && num2Line != null)
{
    //Парсим введеные числа
     int num1 = int.Parse(num1Line);
     int num2 = int.Parse(num2Line);
     
     // Сравниваю числа
     if(num1 > num2)
            {
                Console.WriteLine(num1Line); 
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2Line);
            }
            
            

}
