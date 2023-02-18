void DayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("It's a weekend bruh!");
    }
    else if (dayNum < 6 && dayNum != 0)
    {
        Console.WriteLine("Have to work, business day!");
    }
    else
    {
        Console.WriteLine("Not a weekday, don't mess with me!");
    }
}
int dayNum = 5;
DayOfTheWeek(dayNum);