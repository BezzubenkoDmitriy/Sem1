//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, что бы данные были не пустыми
if(inputLine!=null)
{
    //Создаем массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "понедельник";
    dayOfWeek[1] = "вторник";
    dayOfWeek[2] = "среда";
    dayOfWeek[3] = "четверг";
    dayOfWeek[4] = "пятница";
    dayOfWeek[5] = "суббота";
    dayOfWeek[6] = "воскресенье";

    // Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    //Находим название дня недели по введеному номеру
    string outDayOfWeek = dayOfWeek[inputNumber-1];

    //Выводим данные в консоль
    Console.WriteLine(outDayOfWeek);


}
