﻿// Создаем экземпляр класса Рандомайзер
System.Random numberSintezator = new System.Random();


//Получаем новое случайное число
int number = numberSintezator.Next(10,100);

// Выводим данные в консоль
Console.WriteLine(number);

// Получаем первое и второе число поотдельности
int firstNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
//if(firstNumber>secondNumber)
//{
    //Выводим результат
    //Console.WriteLine(firstNumber);
//}
//else
{
    //Выводим результат
    Console.WriteLine(secondNumber);
}
// Вариант2 решение
char[]digits = numberSintezator.Next(10,100).ToString().ToCharArray();

firstNumber = ((int)digits[0])-48;
secondNumber =((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console. WriteLine(resultNumber);
