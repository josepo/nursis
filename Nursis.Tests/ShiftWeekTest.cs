namespace Nursis.Tests;

public class ShiftWeekTest
{
    [Fact]
    public void CreatesWeekFromCode()
    {
        ShiftWeek week = ShiftWeek.From("- - - MN - - T");

        Assert.Equal(7, week.Shifts.Count);

        Assert.Equal(Shift.None, week.Shifts[0]);
        Assert.Equal(Shift.None, week.Shifts[1]);
        Assert.Equal(Shift.None, week.Shifts[2]);
        Assert.Equal(Shift.EarlyNight, week.Shifts[3]);
        Assert.Equal(Shift.None, week.Shifts[4]);
        Assert.Equal(Shift.None, week.Shifts[5]);
        Assert.Equal(Shift.Late, week.Shifts[6]);
    }
}