namespace Nursis.Tests;

public class SequenceTest
{
    [Fact]
    public void NewSequence()
    {
        Sequence sequence = new(
        [
            ShiftWeek.From("MN - - - T - -")
        ]);

        Assert.NotNull(sequence);
    }

    [Fact]
    public void GetShifts()
    {
        Sequence sequence = new(
        [
            ShiftWeek.From("MN - T MN - - -")
        ]);

        List<Shift> shifts = sequence.GetShifs(week: 1, numOfDays: 2).ToList();

        Assert.Equal(2, shifts.Count);
        Assert.Equal(Shift.EarlyNight, shifts.First());
        Assert.Equal(Shift.None, shifts.Last());
    }
}