namespace BootcampFunctions.Test;
public class CountAllFromTownTest
{
    [Fact]
    public void ShouldBeAbleToCountRegistrationNumbersFromATown()
    {
        Assert.Equal(3, CountAllFromTown.AllFromTown("CL 124,CY 567,CL 345, CJ 456,CL 341","CL"));
    }

    [Fact]
    public void ShouldReturn1ForSingleRegistrationNumberFromBellville()
    {
        Assert.Equal(1, CountAllFromTown.AllFromTown("CY 124,CK 567,CL 345, CJ 456,CL 341","CY"));
    }

    [Fact]
    public void ShouldReturn0IfTheIsNoRegistrationNumberFromTheIndicatorTown()
    {
        Assert.Equal(0, CountAllFromTown.AllFromTown("CY 124,CY 567,CL 345, CJ 456,CL 341","CA"));
    }
}