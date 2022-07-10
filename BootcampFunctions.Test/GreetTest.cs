namespace BootcampFunctions.Test;

public class GreetTest
{
    [Fact]
    public void ShouldBeAbleToGreetAnthony()
    {
        Assert.Equal("Hello, Anthony", Greet.GreetMsg("Anthony"));
    }
    [Fact]
    public void ShouldBeAbleToGreetCode()
    {
        Assert.Equal("Hello, Code", Greet.GreetMsg("Code"));
    }
}