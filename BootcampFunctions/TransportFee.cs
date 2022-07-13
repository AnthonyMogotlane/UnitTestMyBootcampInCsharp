namespace BootcampFunctions;

public class TransportFee
{
    public static string Fee(string shift)
    {
        string transportFee = "";
        switch (shift)
        {
            case "morning":
                transportFee = "R20";
                break;
            case "afternoon":
                transportFee = "R10";
                break;
            case "night":
                transportFee = "free";
                break;
        }
        return transportFee;
    }
}
