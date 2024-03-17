// InventoryItems.cs

namespace FoodPantryApp
{
    public class InventoryItems
    {
        public string Type { get; set; } 
        public string Name { get; set; }
        public int Quantity { get; set; }

        public InventoryItems(string type, string name, int quantity)
        {
            Type = type;
            Name = name;
            Quantity = quantity;
        }

    }
}