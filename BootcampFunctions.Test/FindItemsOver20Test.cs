namespace BootcampFunctionsTest;

public class FindItemsOver20Test
{
    [Fact]
    public void ShouldReturnItemsWhoseQuantityIsOver20()
    {
        // Given
        List<Item> items = new List<Item>();
        items.Add(new Item(){Name = "bananas", Qty = 5});
        items.Add(new Item(){Name = "pears", Qty = 37});
        items.Add(new Item(){Name = "grapes", Qty = 10});
        items.Add(new Item(){Name = "apples", Qty = 25});
        items.Add(new Item(){Name = "kiwis", Qty = 50});
        // When
        List<Item> itemsOver20 = new List<Item>();
        itemsOver20.Add(new Item(){Name = "pears", Qty = 37});
        itemsOver20.Add(new Item(){Name = "apples", Qty = 25});
        itemsOver20.Add(new Item(){Name = "kiwis", Qty = 50});
        // Then
        Assert.Equal(itemsOver20, FindItemsOver20.ItemsOver20(items));
    }

    [Fact]
    public void ShouldReturnAListWith4ItemsWhoseQuantityIsOver20()
    {
        // Given
        List<Item> items = new List<Item>();
        items.Add(new Item(){Name = "grapes", Qty = 5});
        items.Add(new Item(){Name = "pears", Qty = 37});
        items.Add(new Item(){Name = "grapes", Qty = 10});
        items.Add(new Item(){Name = "apples", Qty = 25});
        items.Add(new Item(){Name = "mangos", Qty = 50});
        items.Add(new Item(){Name = "oranges", Qty = 100});
        // When
        List<Item> itemsOver20 = new List<Item>();
        itemsOver20.Add(new Item(){Name = "pears", Qty = 37});
        itemsOver20.Add(new Item(){Name = "apples", Qty = 25});
        itemsOver20.Add(new Item(){Name = "mangos", Qty = 50});
        itemsOver20.Add(new Item(){Name = "oranges", Qty = 100});
        // Then
        Assert.Equal(itemsOver20, FindItemsOver20.ItemsOver20(items));
    }
}