// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Метод работает, как для положительных, так и для отрицательных чисел.

int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}


int SummOfAllNumbers(int a)
{
int summ = 0; 

if(a < 0)
{
   a = Math.Abs(a); 
}

while(a >= 100)
{


summ = summ + (a % 10);
a = a / 10;
}
if(a < 100)
{
summ = summ + (a % 10);
a = a / 10;
summ = summ + a;
}


return summ;

}

int a = ReadNumber("Введите число:");

int Summ = SummOfAllNumbers(a);
Console.WriteLine($"Сумма всех цифр числа = {Summ}");


