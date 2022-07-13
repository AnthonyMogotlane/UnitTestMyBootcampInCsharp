// See https://aka.ms/new-console-template for more information
using BootcampFunctions;

Item item1 = new Item(){Name = "Banana", Qty = 20};
Item item2 = new Item(){Name = "Apple",Qty = 60};
Item item3 = new Item(){Name = "Grape",Qty = 50};

List<Item> listOfItems = new List<Item>();
listOfItems.Add(item1);
listOfItems.Add(item2);
listOfItems.Add(item3);

foreach (var item in FindItemsOver20.ItemsOver20(listOfItems))
{
    Console.WriteLine(item.Name);
}
