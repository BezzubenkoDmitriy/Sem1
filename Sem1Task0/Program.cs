// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем что бы данные не были пустыми
if(inputLine!=null)
{
    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    
  // Находим квадрат числа
    int outNumber = inputNumber*inputNumber;

   // Выводим результат  на консоли
    Console.WriteLine(outNumber);

}
