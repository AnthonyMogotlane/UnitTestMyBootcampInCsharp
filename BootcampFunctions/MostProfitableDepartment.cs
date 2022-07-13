namespace BootcampFunctions;
public class MostProfitableDepartment
{
    public static string ProfitableDepartment(List<Product> listOfProducts)
    {
        // Departments and their total sales as a values
        Dictionary<string, int> salesOfDepartment = new Dictionary<string, int>();

        foreach(var product in listOfProducts)
        {
            if(!salesOfDepartment.ContainsKey(product.Department))
            {
                salesOfDepartment.Add(product.Department, product.Sales);
            }
            else
            {
                salesOfDepartment[product.Department] = salesOfDepartment[product.Department] + product.Sales;
            }
        }

        // Getting the highest total sale
        int highSale = 0;
        foreach (var sale in salesOfDepartment)
        {
            if(sale.Value > highSale) highSale = sale.Value;
        }

        string profitableDepartment = "";
        foreach (var department in salesOfDepartment)
        {
            if(highSale == department.Value) profitableDepartment = department.Key;
        }

        return profitableDepartment;
    }
}