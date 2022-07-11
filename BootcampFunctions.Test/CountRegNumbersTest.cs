namespace BootcampFunctions.Test;
public class CountRegNumbersTest
{
    [Fact]
    public void ShouldBeAbleToCountHowManyRegistrationNumbers()
    {
        Assert.Equal(3, CountRegNumbers.Count("CA 182736,CY 523519,CJ 812328"));
    }

    [Fact]
    public void ShouldReturn2ForTwoRegistrationNumbers()
    {
        Assert.Equal(2, CountRegNumbers.Count("CK 533519,CA 92328"));
    }
    
}