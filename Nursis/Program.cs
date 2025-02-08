using Nursis;

Sequence sequence = new
([
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,

    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,

    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,

    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,

    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,

    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,

    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,

    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,

    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,

    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,

    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,

    ShiftPair.None,
    ShiftPair.Late,
    ShiftPair.EarlyNight,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.None,
    ShiftPair.Late,
]);

DateTime date = new(2025, 1, 1);

foreach (ShiftPair shift in sequence.GetShifs(0, 365))
{
    Console.WriteLine(date.ToShortDateString() + "\t" + shift.ToString());

    date = date.AddDays(1);
}