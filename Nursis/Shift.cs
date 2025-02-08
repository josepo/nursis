namespace Nursis;

public enum ShiftType
{
    None, 
    EarlyNight,
    Late
}

public class Shift {
    public static Shift None = new(ShiftType.None);
    public static Shift EarlyNight = new(ShiftType.EarlyNight);
    public static Shift Late = new(ShiftType.Late);

    private ShiftType _type;

    private Shift(ShiftType type)
    {
        _type = type;
    }

    public override string ToString()
    {
        if (_type == ShiftType.EarlyNight)
            return "MN";

        if (_type == ShiftType.Late)
            return "T";

        return "-";
    }
}