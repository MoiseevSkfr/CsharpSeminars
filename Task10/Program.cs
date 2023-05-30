//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintDegreTable(int number)
{
    for(int i = 1 ; i <= number ; i++)
    {
        Console.Write(Math.Pow(i,2)+ " ");
    }
}

int num = Prompt("Введите число N:");
int num_n = Math.Abs(num);
PrintDegreTable(num);
