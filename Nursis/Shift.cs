namespace Nursis;

public enum Shift
{
    None,
    Early,
    Late,
    Night
}

public class Shifts
{
    public Shift First { get; private set; }
    public Shift Second { get; private set; }

    public Shifts(Shift first, Shift second)
    {
        First = first;
        Second = second;
    }
}