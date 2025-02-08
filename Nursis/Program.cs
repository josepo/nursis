using Nursis;

Sequence sequence = new
([
    ShiftWeek.From("- - - - T MN -"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - - T"),
    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),

    ShiftWeek.From("- T MN - - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - T MN"),

    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - - T MN"),
    ShiftWeek.From("- - - - T MN -"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - T MN -"),

    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - - T"),
    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- T MN - - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- T MN - - - T"),

    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - T MN -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),
    ShiftWeek.From("- - T MN - - -"),
    ShiftWeek.From("T MN - - - T MN"),
    ShiftWeek.From("- - - T MN - -"),

    ShiftWeek.From("- T MN - - - T"),
    ShiftWeek.From("MN - - - - T MN")
]);

DateTime date = new(2025, 1, 1);

foreach (Shift shift in sequence.GetShifs(week: 24, numOfDays: 365))
{
    Console.WriteLine(date.ToShortDateString() + "\t" + shift.ToString());

    date = date.AddDays(1);
}