namespace BootcampFunctions.Test;

public class IsWeekdayTest
{
    [Fact]
    public void ShouldReturnTrueForTheDayOfTheWeek()
    {
        Assert.True(IsWeekday.Weekday("Monday"));
    }
    [Fact]
    public void ShouldReturnFalseForTheDayWhichIsAWeekend()
    {
        Assert.False(IsWeekday.Weekday("Sunday"));
    }
}