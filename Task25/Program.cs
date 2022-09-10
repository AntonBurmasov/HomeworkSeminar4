// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

// Алгоритм работает, как для положительных, так и для отрицательных чисел A. Не работает для отрицательных чисел B, используется тип данных int.


Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int count = 1;
int degree = A;

if(B < 0)
{
Console.WriteLine("Вы ввели недопустимое значение числа B для используемого типа данных.");
return;
}

while(count < B)
{
 degree = degree * A;
 count = count + 1;
}

if(B == 0)
{
degree = 1;
}

if(A < 0)
{
degree = -Math.Abs(degree);
}


Console.WriteLine($"Число A, возведенное в степень B равно {degree}");