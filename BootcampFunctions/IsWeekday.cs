namespace BootcampFunctions;
public class IsWeekday
{
    public static bool Weekday(string day)
    {
        string[] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        return (weekdays.Contains(day));
    }
    
}