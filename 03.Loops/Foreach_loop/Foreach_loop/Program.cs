string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

System.Console.WriteLine("Lenght of the array: " + weekDays.Length);

for (int i = 0; i < weekDays.Length; i++)
{
    System.Console.WriteLine(i);
}

// foreach loop

foreach (string day in weekDays)
{
    System.Console.WriteLine(day);
}