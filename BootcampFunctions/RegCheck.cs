
namespace BootcampFunctions;
public class RegCheck
{
    public static bool Check(string regNumber, string indicator)
    {
        string[] indicators = {"GP", "EC", "MP", "L"};
        foreach(var i in indicators) {
            if(regNumber.EndsWith(i) && indicator == i)
                return true;
        }
        return false;
    }
}