namespace BootcampFunctions;

public class FindItemsOver
{
    public static List<Item> ItemsOver(List<Item> listOfItems, int threshold)
    {
        List<Item> itemsOverThreshold = new List<Item>();
        foreach (Item item in listOfItems)
        {
            if(item.Qty > threshold) itemsOverThreshold.Add(item);
        }
        return itemsOverThreshold;
    }
}