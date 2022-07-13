namespace BootcampFunctions;
public class FindItemsOver20
{
    public static List<Item> ItemsOver20(List<Item> listOfItems)
    {
        List<Item> itemsOver20 = new List<Item>();
        foreach (Item item in listOfItems)
        {
            if(item.Qty > 20) itemsOver20.Add(item);
        }
        return itemsOver20;
    }
}