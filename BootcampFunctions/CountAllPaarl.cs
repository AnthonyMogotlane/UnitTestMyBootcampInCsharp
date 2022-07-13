namespace BootcampFunctions;

public class CountAllPaarl
{
    public static int AllPaarl(string regNumbers)
    {
        var fromPaarl = new List<string>();
        foreach (var reg in regNumbers.Split(","))
            if(reg.Trim().StartsWith("CJ")) fromPaarl.Add(reg);
            
        return fromPaarl.Count;
    }
}