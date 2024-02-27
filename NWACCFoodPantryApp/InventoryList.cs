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
        public void AddItem(InventoryItems item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            items.Add(item);
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