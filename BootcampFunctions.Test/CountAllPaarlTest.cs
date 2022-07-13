namespace BootcampFunctions.Test;

public class CountAllPaarlTest
{
    [Fact]
    public void ShouldBeAbleToReturnTheNumberOfRegistrationNumbersFromPaarl()
    {
        Assert.Equal(3, CountAllPaarl.AllPaarl("CJ 345 123, CJ 2345, CL 123-546, CK 345, CJ 123"));
    }

    [Fact]
    public void ShouldReturn2ForRegistrationThatAreFromPaarl()
    {
        Assert.Equal(2, CountAllPaarl.AllPaarl("CJ 345 123, CK 345, CJ 123"));
    }
}