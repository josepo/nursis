using System.Diagnostics.Tracing;

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
    public static ShiftPair None = new(Shift.None, Shift.None);
    public static ShiftPair EarlyNight = new(Shift.Early, Shift.Night);
    public static ShiftPair Late = new(Shift.Late, Shift.None);

    public Shift First { get; private set; }
    public Shift Second { get; private set; }

    public ShiftPair(Shift first, Shift second)
    {
        First = first;
        Second = second;
    }

    public override string ToString()
    {
        if ((First == Shift.Late) || (Second == Shift.Late))
            return "T";

        if ((First == Shift.Early) && (Second == Shift.Night))
            return "MN";

        return "-";
    }
}