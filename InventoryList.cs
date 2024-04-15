// InventoryList.cs

namespace FoodPantryApp
{
    /// <summary>
    /// Class that models a list if Inventory Items.
    /// </summary>
    public class InventoryList
    {
        /// <summary>
        /// The list of items.
        /// </summary>
        private List<InventoryItems> items;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryList"/> class.
        /// </summary>
        public InventoryList()
        {
            items = new List<InventoryItems>();
        }

        /// <summary>
        /// Function that adds an InventoryItems object to the list.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        public void AddItem(string type, string name, int quantity)
        {
            // Create a new InventoryItems object with the input values
            InventoryItems newItem = new InventoryItems(type, name, quantity);
            items.Add(newItem);
        }

        /// <summary>
        /// The function that removes an item from the list.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public void RemoveItem(InventoryItems item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }
            items.Remove(item);
        }

        /// <summary>
        /// The get all items function.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<InventoryItems> GetAllItems()
        {
            return new List<InventoryItems>(items);
        }

        /// <summary>
        /// Function that gets an item by name.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="InventoryItems?"/>.
        /// </returns>
        public InventoryItems? GetItemByName(string name)
        {
            return items.FirstOrDefault(item => item.Name == name);
        }

        /// <summary>
        /// Gets the number of items in the list.
        /// </summary>
        public int Count { get { return items.Count; } }

        /// <summary>
        /// The function that empties the list.
        /// </summary>
        public void Clear() { items.Clear(); }
    }
}