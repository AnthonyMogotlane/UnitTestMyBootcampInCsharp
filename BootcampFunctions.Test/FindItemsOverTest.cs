namespace BootcampFunctionsTest;

public class FindItemsOverTest
{
    [Fact]
    public void ShouldReturnAListOfItemsWhoseQuantityIsOverThreshold()
    {
        // Given
        List<Item> items = new List<Item>();
        items.Add(new Item() {Name = "watermelon", Qty = 15});
        items.Add(new Item() {Name = "grapefruit", Qty = 45});
        items.Add(new Item() {Name = "apples", Qty = 75});
        items.Add(new Item() {Name = "pears", Qty = 10});
        // When
        List<Item> itemOverThreshold = new List<Item>();
        itemOverThreshold.Add(new Item() {Name = "grapefruit", Qty = 45});
        itemOverThreshold.Add(new Item() {Name = "apples", Qty = 75});
        // Then
        Assert.Equal(itemOverThreshold, FindItemsOver.ItemsOver(items, 40));
    }

    [Fact]
    public void ShouldReturnEmptyListIfTheIsNoQuantityOverThreshold()
    {
        // Given
        List<Item> items = new List<Item>();
        items.Add(new Item() {Name = "watermelon", Qty = 15});
        items.Add(new Item() {Name = "grapefruit", Qty = 45});
        items.Add(new Item() {Name = "apples", Qty = 75});
        items.Add(new Item() {Name = "pears", Qty = 10});
        // When
        List<Item> itemOverThreshold = new List<Item>();

        // Then
        Assert.Equal(itemOverThreshold, FindItemsOver.ItemsOver(items, 200));
    }
}