namespace Nursis;

public class Sequence
{
    private List<Shifts> _shifts = new();

    public Sequence(List<Shifts> shifts)
    {
        _shifts = shifts;
    }
}
