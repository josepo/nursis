namespace Nursis;

public class Sequence
{
    List<Shifts> _shifts = new();

    public Sequence(List<Shifts> shifts)
    {
        _shifts = shifts;
    }
}
