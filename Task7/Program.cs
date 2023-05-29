int x1 = Promt("Введите координату x: ");
int y1 = Promt("Введите координату y: ");
FindCoordinate(x1,y1);


int Promt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindCoordinate(int x, int y)
{
    if(x>0 && y>0)
    {
        Console.WriteLine("I четверть");
    }
    if(x<0 && y>0)
    {
        Console.WriteLine("II четверть");
    }
    if(x<0 && y<0)
    {
        Console.WriteLine("III четверть");
    }
    if(x>0 && y<0)
    {
        Console.WriteLine("IV четверть");
    }
}