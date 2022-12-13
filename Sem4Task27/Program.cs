





//Запрос данных у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//Метод вывода результата
void PrintData(string res)
{
    Console.WriteLine(res);
}
//Метод суммы цифр
  int SumNumber(int numberN)
  {
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int numberN = ReadData("Введите число N:");
int sumNumber = SumNumber(numberN);
PrintData("Сумма цифр в числе: " + sumNumber);