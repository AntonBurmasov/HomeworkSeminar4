// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем.




int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());

}

int[] array = new int[8];
int count = 0;
int i = 0;

while(count < array.Length)
{
array[i] = ReadNumber("Введите элемент массива:");
i++;
count++;
}

Console.WriteLine(string.Join(", ", array));