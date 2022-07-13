namespace BootcampFunctions;

public class RegCheckTest
{

    [Fact]
    public void IsGP_ShouldReturnTrue()
    {
        Assert.True(RegCheck.Check("DV 23 NB GP", "GP"));
    }
    [Fact]
    public void IsMP_ShouldReturnFalse()
    {
        Assert.False(RegCheck.Check("DV 23 LP GP", "MP"));
    }
    [Fact]
    public void IsBellville_ShouldReturnFalse()
    {
        Assert.False(RegCheck.Check("CY 189-012", "CY"));
    }
    [Fact]
    public void IsDurban_ShouldReturnFalse()
    {
        Assert.False(RegCheck.Check("DV 23 NB GP", "ND"));
    }
}