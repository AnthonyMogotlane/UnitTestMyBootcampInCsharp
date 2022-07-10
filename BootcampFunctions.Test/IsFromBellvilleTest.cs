
namespace BootcampFunctions.Test;

public class IsFromBellvilleTest
{
    [Fact]
    public void ShouldReturnTrue()
    {
        Assert.Equal(true, IsFromBellville.FromBellville("CY"));
    }
}