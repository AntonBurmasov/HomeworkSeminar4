// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем.




int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());

}

int[] array = new int[8];

array[0] = ReadNumber("Введите элемент массива 1:");

array[1] = ReadNumber("Введите элемент массива 2:");

array[2] = ReadNumber("Введите элемент массива 3:");

array[3] = ReadNumber("Введите элемент массива 4:");

array[4] = ReadNumber("Введите элемент массива 5:");

array[5] = ReadNumber("Введите элемент массива 6:");

array[6] = ReadNumber("Введите элемент массива 7:");

array[7] = ReadNumber("Введите элемент массива 8:");

Console.WriteLine(string.Join(", ", array));