namespace BootcampFunctions;

public class RegCheckTest
{

    [Fact]
    public void IsGP_ShouldReturnTrue()
    {
        Assert.Equal(true, RegCheck.Check("DV 23 NB GP", "GP"));
    }
    [Fact]
    public void IsMP_ShouldReturnFalse()
    {
        Assert.Equal(false, RegCheck.Check("DV 23 LP GP", "MP"));
    }
    [Fact]
    public void IsBellville_ShouldReturnFalse()
    {
        Assert.Equal(false, RegCheck.Check("CY 189-012", "CY"));
    }
    [Fact]
    public void IsDurban_ShouldReturnFalse()
    {
        Assert.Equal(false, RegCheck.Check("DV 23 NB GP", "ND"));
    }
}