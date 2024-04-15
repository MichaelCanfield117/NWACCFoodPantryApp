// InventoryItems.cs

namespace FoodPantryApp
{
    /// <summary>
    /// Class that models an inventory item.
    /// </summary>
    public class InventoryItems
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItems"/> class.
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
        public InventoryItems(string type, string name, int quantity)
        {
            Type = type;
            Name = name;
            Quantity = quantity;
        }

    }
}