
namespace BootcampFunctions.Test;

public class IsFromBellvilleTest
{
    [Fact]
    public void ShouldReturnTrue()
    {
        Assert.True(IsFromBellville.FromBellville("CY"));
    }

    [Fact]
    public void ShouldReturnFalse()
    {
        Assert.False(IsFromBellville.FromBellville("CA"));
    }
}