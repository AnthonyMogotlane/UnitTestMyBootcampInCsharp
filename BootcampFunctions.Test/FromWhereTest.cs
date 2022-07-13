public class FromWhereTest
{
    [Fact]
    public void ShouldReturnBellvilleForRegistrationIndicatorCY()
    {
        Assert.Equal("Bellville", FromWhere.WhichTown("CY"));
    }

    [Fact]
    public void ShouldReturnPaarlForRegistrationIndicatorCJ()
    {
        Assert.Equal("Paarl", FromWhere.WhichTown("CJ"));
    }

    [Fact]
    public void ShouldReturnCapeTownForRegistrationIndicatorCA()
    {
        Assert.Equal("Cape Town", FromWhere.WhichTown("CA"));
    }

    [Fact]
    public void ShouldReturnMessageIfNoIndicatorMatchesTownsAvailable()
    {
        Assert.Equal("Some other place!", FromWhere.WhichTown("CB"));
    }
}