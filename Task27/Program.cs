// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}


int SummOfAllNumbers(int a)
{
int summ = 0;    

while(a / 10 > 1)
{
summ = summ + (a % 10);
}
summ = summ + (a / 10);

return summ;

}

int a = ReadNumber("Введите число:");

int Summ = SummOfAllNumbers(a);
Console.WriteLine($"Сумма всех цифр числа = {Summ}");


