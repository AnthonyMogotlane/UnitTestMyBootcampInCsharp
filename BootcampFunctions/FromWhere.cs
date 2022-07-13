namespace BootcampFunctions;
public class FromWhere
{
    public static string WhichTown(string indicator)
    {
        var towns = new Dictionary<string, string>();
        towns.Add("CY", "Bellville");
        towns.Add("CJ", "Paarl");
        towns.Add("CA", "Cape Town");

        string[] townIndicators = towns.Keys.ToArray();
        foreach (var townIndicator in townIndicators)
        {
            if(indicator == townIndicator)
            {
                return towns[townIndicator];
            }
        }
        return "Some other place!";
    }
}