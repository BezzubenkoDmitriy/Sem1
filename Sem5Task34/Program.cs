
Console.WriteLine("Введите размер");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
GenArr(numbers);
PrintArray(numbers);
int count = 0;
//Цикл выявление четности
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего в массиве чисел {numbers.Length} , {count} из них чётные");
//Метод рандомного заполнение массива
void GenArr(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
//Метод вывода массива  
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

