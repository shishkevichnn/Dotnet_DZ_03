/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа 
с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да*/
Console.Write("Введите пятизначное число: ");
int numberA = int.Parse(Console.ReadLine());
int result1 = numberA / 10000;
int result2 = numberA % 10;
int a = numberA / 1000;
int result3 = a % 10;
int b = numberA % 100;
int result4 = b / 10;
{
if (numberA < 10000 || numberA > 100000)
Console.WriteLine("Введенное число не пятизначное");   
else
{
    if (result1 == result2 && result3 == result4)
    Console.WriteLine("Да");   
    else
    Console.WriteLine("Нет");
}
}
