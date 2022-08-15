// Домашнее задание №3
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Insert 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int num1 = number / 10000 % 10;
// int num2 = number / 1000 % 10;
// int rev1 = number / 10 % 10;
// int rev2 = number % 10;
// int nul = number / 10000;

// if (nul < 1 || nul > 9)
// {
//     Console.WriteLine(number + " -> " + "Not 5-digit number");
// }
// else if (num1 == rev2 && num2 == rev1)
// {
//     Console.WriteLine(number + " -> Yes, this is palindrom");
// }
// else
// {
//     Console.WriteLine(number + " -> No, this is not palindrom");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X для точки A: ");
// int xA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y для точки A: ");
// int yA=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Координату Z для точки A");
// int zA=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X для точки B: ");
// int xB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y для точки B: ");
// int yB=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координату Z для точки B");
// int zB=Convert.ToInt32(Console.ReadLine());

// double AB = Math.Sqrt(Math.Pow(xB-xA,2) +Math.Pow(yB-yA,2)+ Math.Pow(zB-zA,2));

// Console.WriteLine("Расстояние между A и B: " + Math.Round(AB, 2));

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// while (start <= n)
// {
//     Console.WriteLine($"Куб от числа {start} = {Math.Pow(start, 3)} ");
//     start++;
// }