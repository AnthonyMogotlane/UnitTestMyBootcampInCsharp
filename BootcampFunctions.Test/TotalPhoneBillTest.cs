namespace BootcampFunctions.Test;

public class TotalPhoneBillTest
{
    [Fact]
    public void ShouldReturnTheTotalBillOfCallsAndSms()
    {
       Assert.Equal("R7,45", TotalPhoneBill.PhoneBill("call, sms, call, sms, sms"));
    }

    [Fact]
    public void ShouldReturnTheTotalBillForCalls()
    {
       Assert.Equal("R11,00", TotalPhoneBill.PhoneBill("call, call, call, call"));
    }

    [Fact]
    public void ShouldReturnTheTotalBillForSms()
    {
       Assert.Equal("R2,60", TotalPhoneBill.PhoneBill("sms, sms, sms, sms"));
    }
}