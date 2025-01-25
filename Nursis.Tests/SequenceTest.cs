namespace Nursis.Tests;

public class SequenceTest
{
    [Fact]
    public void NewSequence()
    {
        Sequence sequence = new(
        [
            new Shifts(first: Shift.Early, second: Shift.Night),
            new Shifts(first: Shift.None, second: Shift.None),
            new Shifts(first: Shift.None, second: Shift.Late)
        ]);

        Assert.NotNull(sequence);
    }
}