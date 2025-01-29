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

for (int i = 0; i < 365; i++)
{
    Console.WriteLine(date.AddDays(i).ToShortDateString());
}