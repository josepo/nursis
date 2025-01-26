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
}