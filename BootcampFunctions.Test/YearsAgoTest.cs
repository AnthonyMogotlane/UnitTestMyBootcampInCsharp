namespace BootcampFunctionsTest;
public class YearsAgoTest
{
    [Fact]
    public void ShouldBeAbleToCalculateHowManyYearsAgoSince2012()
    {   
        Assert.Equal(10, YearsAgo.Ago(2012));
    }

    [Fact]
    public void ShouldBeAbleToCalculateHowManyYearsAgoSince2020()
    {   
        Assert.Equal(2, YearsAgo.Ago(2020));
    }
}