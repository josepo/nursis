using Nursis;

Sequence sequence = new
([
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,

    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,

    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,

    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,

    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,

    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,

    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,

    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,

    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,

    Shift.None,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,

    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,

    Shift.None,
    Shift.Late,
    Shift.EarlyNight,
    Shift.None,
    Shift.None,
    Shift.None,
    Shift.Late,
]);

DateTime date = new(2025, 1, 1);

foreach (Shift shift in sequence.GetShifs(0, 365))
{
    Console.WriteLine(date.ToShortDateString() + "\t" + shift.ToString());

    date = date.AddDays(1);
}