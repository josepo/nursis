namespace Nursis.Tests;

public class DateTest
{
    [Fact]
    public void NewDate()
    {
        Date date = new(2024, 5, 2);

        Assert.Equal(2024, date.Year);
        Assert.Equal(5, date.Month);
        Assert.Equal(2, date.Day);
    }
}