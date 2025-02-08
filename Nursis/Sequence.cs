namespace Nursis;

public class Sequence
{
    private List<Shift> _shifts = [];

    public Sequence(List<Shift> shifts)
    {
        _shifts = shifts;
    }

    public IEnumerable<Shift> GetShifs(int start, int number)
    {
        int returnedShifts = 0;
        int totalNumberOfShifts = _shifts.Count;
        int i = start % totalNumberOfShifts;

        while (returnedShifts < number)
        {
            yield return _shifts.ElementAt(i);

            i = (i + 1) % totalNumberOfShifts;
            returnedShifts++;
        }
    }
}
