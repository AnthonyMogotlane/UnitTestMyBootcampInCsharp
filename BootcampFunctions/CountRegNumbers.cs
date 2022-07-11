namespace BootcampFunctions;

public class CountRegNumbers
{
    public static int Count(string regNumbers) => regNumbers.Split(",").Length;
}