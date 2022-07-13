namespace BootcampFunctions;

public class CountAllFromTown
{
    public static int AllFromTown(string regNumbers, string indicator)
    {
        var regNumList = new List<string>();
        foreach (var reg in regNumbers.Split(","))
        {
            if(reg.Trim().StartsWith(indicator)) regNumList.Add(reg);
        }
        return regNumList.Count;
    }
}