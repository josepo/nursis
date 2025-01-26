namespace Nursis;

public class Sequence
{
    private List<ShiftPair> _shifts = new();

    public Sequence(List<ShiftPair> shifts)
    {
        _shifts = shifts;
    }

    public IEnumerable<ShiftPair> GetShifs(int start, int number)
    {
        int returnedShifts = 0;
        int totalNumberOfShifts = _shifts.Count;

        for (int i = start % totalNumberOfShifts; returnedShifts < number; i = (i + 1) % totalNumberOfShifts)
        {
            yield return _shifts.ElementAt(i);

            returnedShifts++;
        }
    }
}
