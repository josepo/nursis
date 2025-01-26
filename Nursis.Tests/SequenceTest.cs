namespace Nursis.Tests;

public class SequenceTest
{
    [Fact]
    public void NewSequence()
    {
        Sequence sequence = new(
        [
            new ShiftPair(first: Shift.Early, second: Shift.Night),
            new ShiftPair(first: Shift.None, second: Shift.None),
            new ShiftPair(first: Shift.None, second: Shift.Late)
        ]);

        Assert.NotNull(sequence);
    }

    [Fact]
    public void GetShifts()
    {
        Sequence sequence = new(
        [
            new ShiftPair(first: Shift.Early, second: Shift.Night),
            new ShiftPair(first: Shift.None, second: Shift.None),
            new ShiftPair(first: Shift.None, second: Shift.Late)
        ]);


        List<ShiftPair> shifts = sequence.GetShifs(start: 2, number: 2).ToList();

        Assert.Equal(2, shifts.Count);
        Assert.Equal(Shift.Late, shifts.First().Second);
        Assert.Equal(Shift.Early, shifts.Last().First);
    }
}