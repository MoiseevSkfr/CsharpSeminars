// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int num = Promt("Введите номер четверти: ");
FindCoordinate(num);


int Promt(string message)
{
    Console.WriteLine( message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindCoordinate(int num1)
{
    if(num1 == 1)
    {
        Console.WriteLine("Координаты x = от 0 до 500, координаты y = от 0 до 500 ");
    }
    if(num1 == 2)
    {
        Console.WriteLine("Координаты x = от -1 до -500, координаты y = от 0 до 500 ");
    }
    if(num1 == 3)
    {
        Console.WriteLine("Координаты x = от -1 до -500, координаты y = от -1 до -500 ");
    }
    if(num1 == 4)
    {
        Console.WriteLine("Координаты x = от 0 до 500, координаты y = от -1 до -500 ");
    }
}