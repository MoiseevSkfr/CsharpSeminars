﻿//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите число 1:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number1 = int.Parse(Console.ReadLine());
FindingMultiple(number, number1);

void FindingMultiple(int num,int num1)
{
    int result = num % 10;
    if (num % num1 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    if (num % num1 != 0)
    {
        Console.WriteLine("Второе число не кратно первому, остаток " + result);
    }
}


