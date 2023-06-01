// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Clear();
string mess = "Введите число:";
int num = Prompt(mess);
int res = GetQuantityNumbs(num);
Console.Write($"Кол-во цифр в числе -> {res}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetQuantityNumbs(int number)
{
    int result = 0;
    
    for (int count = 0; number > 0; count++)
    {
        number = number / 10;
        
        result = result + 1;
    }
    return result;
}