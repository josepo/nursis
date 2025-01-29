namespace Nursis;

public class Sequence
{
    private List<ShiftPair> _shifts = [];

    public Sequence(List<ShiftPair> shifts)
    {
        _shifts = shifts;
    }

    public IEnumerable<ShiftPair> GetShifs(int start, int number)
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
