namespace Nursis;

public class Sequence
{
    private List<ShiftPair> _shifts = new();

    public Sequence(List<ShiftPair> shifts)
    {
        _shifts = shifts;
    }
}
