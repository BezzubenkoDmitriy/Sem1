
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
// Метод возведения в степень
int Pow(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }

    return result;
}

int numberA = ReadData("Введите число А");
int numberB = ReadData("Введите число B");
int WPow = Pow(numberA, numberB);
PrintData("Ответ:"+WPow);

