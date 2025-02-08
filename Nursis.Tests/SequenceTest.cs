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

        List<Shift> shifts = sequence.GetShifs(start: 2, number: 2).ToList();

        Assert.Equal(2, shifts.Count);
        Assert.Equal(Shift.Late, shifts.First());
        Assert.Equal(Shift.EarlyNight, shifts.Last());
    }
}