namespace BootcampFunctions.Test;
public class TransportFeeTest
{
    [Fact]
    public void ShouldReturnTheFeeForMorningShift()
    {
        Assert.Equal("R20", TransportFee.Fee("morning"));
    }

    [Fact]
    public void ShouldReturnTheFeeForAfternoonShift()
    {
        Assert.Equal("R10", TransportFee.Fee("afternoon"));
    }

    [Fact]
    public void ShouldReturnTheFeeForFreeForNightShift()
    {
        Assert.Equal("free", TransportFee.Fee("night"));
    }
}