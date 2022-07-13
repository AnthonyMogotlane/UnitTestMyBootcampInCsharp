namespace BootcampFunctionsTest;


public class MostProfitableDepartmentTest
{
    [Fact]
    public void ShouldReturnOutdoorAsTheMostProfitableDepartment()
    {
        // Given
        List<Product> products = new List<Product>()
        {
            new Product() {Department = "hardware", Sales = 4500, Day = "Monday"},
            new Product() {Department = "outdoor", Sales = 1500, Day = "Monday"},
            new Product() {Department = "carpentry", Sales = 5500, Day = "Monday"},
            new Product() {Department = "hardware", Sales = 7500, Day = "Tuesday"},
            new Product() {Department = "outdoor", Sales = 2505, Day = "Tuesday"},
            new Product() {Department = "carpentry", Sales = 1540, Day = "Tuesday"},
            new Product() {Department = "hardware", Sales = 1500, Day = "Wednesday"},
            new Product() {Department = "outdoor", Sales = 8507, Day = "Wednesday"},
            new Product() {Department = "carpentry", Sales = 8009, Day = "Wednesday"},
            new Product() {Department = "hardware", Sales = 12000, Day = "Thursday"},
            new Product() {Department = "outdoor", Sales = 18007, Day = "Thursday"},
            new Product() {Department = "carpentry", Sales = 6109, Day = "Thursday"},
            new Product() {Department = "hardware", Sales = 7005, Day = "Friday"},
            new Product() {Department = "outdoor", Sales = 12006, Day = "Friday"},
            new Product() {Department = "carpentry", Sales = 16109, Day = "Friday"}
        };
        // When
        string profitableDepartment = "outdoor";
        // Then
        Assert.Equal(profitableDepartment, MostProfitableDepartment.ProfitableDepartment(products));
    }

    [Fact]
    public void ShouldReturnHardwareAsTheMostProfitableDepartment()
    {
        // Given
        List<Product> products = new List<Product>()
        {
            new Product() {Department = "hardware", Sales = 7800, Day = "Monday"},
            new Product() {Department = "outdoor", Sales = 1500, Day = "Monday"},
            new Product() {Department = "carpentry", Sales = 5500, Day = "Monday"},
            new Product() {Department = "hardware", Sales = 7500, Day = "Tuesday"},
            new Product() {Department = "outdoor", Sales = 2505, Day = "Tuesday"},
            new Product() {Department = "carpentry", Sales = 1540, Day = "Tuesday"},
            new Product() {Department = "hardware", Sales = 2500, Day = "Wednesday"},
            new Product() {Department = "outdoor", Sales = 8507, Day = "Wednesday"},
            new Product() {Department = "carpentry", Sales = 8009, Day = "Wednesday"},
            new Product() {Department = "hardware", Sales = 20000, Day = "Thursday"},
            new Product() {Department = "outdoor", Sales = 18007, Day = "Thursday"},
            new Product() {Department = "carpentry", Sales = 6109, Day = "Thursday"},
            new Product() {Department = "hardware", Sales = 20005, Day = "Friday"},
            new Product() {Department = "outdoor", Sales = 12006, Day = "Friday"},
            new Product() {Department = "carpentry", Sales = 16109, Day = "Friday"}
        };
        // When
        string profitableDepartment = "hardware";
        // Then
        Assert.Equal(profitableDepartment, MostProfitableDepartment.ProfitableDepartment(products));
    }
}