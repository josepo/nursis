namespace Nursis;

public enum Shift
{
    None,
    Early,
    Late,
    Night
}

public class ShiftPair
{
    public Shift First { get; private set; }
    public Shift Second { get; private set; }

    public ShiftPair(Shift first, Shift second)
    {
        First = first;
        Second = second;
    }
}