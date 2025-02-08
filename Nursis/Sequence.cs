namespace Nursis;

public class Sequence
{
    private List<Shift> _shifts = [];

    public Sequence(params ShiftWeek[] weeks)
    {
        foreach (ShiftWeek week in weeks)
        {
            for (int i = 0; i < 7; i++)
                _shifts.Add(week.Shifts[i]);
        }
    }

    public IEnumerable<Shift> GetShifs(int week, int numOfDays)
    {
        int returnedShifts = 0;
        int totalNumberOfShifts = _shifts.Count;
        int start = (week - 1) * 7;
        int i = start % totalNumberOfShifts;

        while (returnedShifts < numOfDays)
        {
            yield return _shifts.ElementAt(i);

            i = (i + 1) % totalNumberOfShifts;
            returnedShifts++;
        }
    }
}
