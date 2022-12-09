
//Вводим данные (1 этап)
//Console.WriteLine("Введите кордитнату X");
//int coordX = int.Parse(Console.ReadLine()??"0");

//Console.WriteLine("Введите кордитнату Y");
//int coordY = int.Parse(Console.ReadLine()??"0");

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int. Parse(Console.ReadLine()??"0");
}

int coordX = ReadData("Введите кордитнату X");
int coordY = ReadData("Введите кордитнату Y");

//Решение методом 2  Метод определяет по координатам 
void PrintQuterTest()
{

    if(coordX>0&&coordY>0) Console.WriteLine("Точка четверти 1");
    if(coordX>0&&coordY<0) Console.WriteLine("Точка четверти 2");
    if(coordX<0&&coordY<0) Console.WriteLine("Точка четверти 3");
    if(coordX<0&&coordY>0) Console.WriteLine("Точка четверти 4");

}


PrintQuterTest();


// Решение (2этап)
//if(coordX>0&&coordY>0) Console.WriteLine("Точка четверти 1");

//if(coordX>0&&coordY<0) Console.WriteLine("Точка четверти 2");

//if(coordX<0&&coordY<0) Console.WriteLine("Точка четверти 3");

//if(coordX<0&&coordY>0) Console.WriteLine("Точка четверти 4");


