//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.Clear();
string mess = "Введите число:";
int num = Prompt(mess);
int result = GetProductNums(num);
Console.WriteLine($"Произведение чисел от 1 до N = {result}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetProductNums(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res = res * i;
        Console.WriteLine(res + " ");
    }
    return res;
}