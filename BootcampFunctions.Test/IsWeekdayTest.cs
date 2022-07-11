namespace BootcampFunctions.Test;

public class IsWeekdayTest
{
    [Fact]
    public void ShouldReturnTrueForTheDayOfTheWeek()
    {
        Assert.Equal(true, IsWeekday.Weekday("Monday"));
    }
    [Fact]
    public void ShouldReturnFalseForTheDayWhichIsAWeekend()
    {
        Assert.Equal(false, IsWeekday.Weekday("Sunday"));
    }
}