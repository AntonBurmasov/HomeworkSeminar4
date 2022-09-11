// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

// Метод работает, как для положительных, так и для отрицательных чисел A.



int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());

}

int AtoDegreeB(int A, int B)
{


int count = 1;
int degree = A;

if(B < 0)
{
Console.WriteLine("Вы ввели недопустимое значение числа B для используемого типа данных.");
return -1;
}

if(B == 0 && A == 0)
{
Console.WriteLine("Вы ввели недопустимые значения чисел A и B.");
return -1;    
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

if(A < 0 && B % 2 == 0)
{
degree = Math.Abs(degree);
}

if(A < 0 && B % 2 > 0)
{
degree = -Math.Abs(degree);
}

if(A < 0 && B == 0)
{
degree = 1;
}

return degree;


}

int A = ReadNumber("Введите число A:");

int B = ReadNumber("Введите число B:");

int result = AtoDegreeB(A, B);

Console.WriteLine($"Число A, возведенное в степень B, равно {result}");