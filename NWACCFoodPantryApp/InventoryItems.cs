// InventoryItems.cs

namespace FoodPantryApp
{
    public class InventoryItems
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public InventoryItems(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}