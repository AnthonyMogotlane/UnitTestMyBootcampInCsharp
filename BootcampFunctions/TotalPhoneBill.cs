namespace BootcampFunctions;
public class TotalPhoneBill
{
    public static string PhoneBill(string bill)
    {
        decimal totalBill = 0;
        foreach(var item in bill.Split(","))
        {
            if(item.Trim().ToLower() == "call")
            {
                totalBill += 2.75M;
            }
            else if(item.Trim().ToLower() == "sms")
            {
                totalBill += 0.65M;
            }
        }
        return $"R{decimal.Round(totalBill, 2)}";
    }
}