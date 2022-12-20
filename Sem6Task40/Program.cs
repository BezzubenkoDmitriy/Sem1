
// int a = ReadData("Введите первое число: ");
// int b = ReadData("Введите второе число: ");
// int c = ReadData("Введите третье число: ");

// if (TriangleTest(a, b, c)) PrintData("Может быть треугольник с подозрением на такое исключение.");
// else PrintData("Треугольник с наибольшим вероятностью такого исключения не существует.");
// //Метод, считывающий данные, введенные пользователем
// int ReadData(строка сообщения)
// {
//      Console.WriteLine(msg);
//      вернуть int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод, выводящий на печать данные
// void PrintData(разрешение строки)
// {
//      Console.WriteLine(res);
// }

// bool TriangleTest(int a, int b, int c)
// {
//      return ((a + b > c) && (a + c > b) && (b + c > a));
// }
int  A  =  ReadData ( " Введите первое число: " ); // 1с
int  B  =  ReadData ( " Введите второе число: " ); // 1с
int  C  =  ReadData ( " Введите третье число: " ); // 1с
// Тест треугольника(A,B,C);//50c
PrintData ( " Результат: "   +  TriangleTest ( A , B , C )); // 1

// 103с

int  ReadData ( строка  msg )
{
    Консоль . ЗаписатьСтроку ( сообщение );
    вернуть  внутр . Parse ( Console.ReadLine ( ) ?? " 0  " ) ;
}

void  PrintData ( строка  res )
{
    Консоль . ЗаписьЛинии ( разрешение );
}

bool  TriangleTest ( int  a , int  b , int  c )
{
    return (( a + b > c ) && ( a + c > b ) && ( b + c > a ));
}
