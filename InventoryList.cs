// InventoryList.cs

namespace FoodPantryApp
{
    public class InventoryList
    {
        private List<InventoryItems> items;
        public InventoryList()
        {
            items = new List<InventoryItems>();
        }

        // Method to add an item to the inventory list
        public void AddItem(string type, string name, int quantity)
        {
            // Create a new InventoryItems object with the input values
            InventoryItems newItem = new InventoryItems(type, name, quantity);
            items.Add(newItem);
        }

        // Method to remove an item from the inventory list
        public void RemoveItem(InventoryItems item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            items.Remove(item);
        }

        // Method to retrieve all items from the inventory list
        public List<InventoryItems> GetAllItems()
        {
            return new List<InventoryItems>(items);
        }

        // Method to retrieve an item by name from the inventory list
        public InventoryItems? GetItemByName(string name)
        {
            return items.FirstOrDefault(item => item.Name == name);
        }
    }
}