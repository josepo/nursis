namespace Nursis;

public class Date
{
    public int Year { get; private set; }
    public int Month { get; private set; }
    public int Day { get; private set; }

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }
}