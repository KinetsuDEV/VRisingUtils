using ProjectM;
using Unity.Entities;

namespace VRisingUtils.Models
{
    public class InventoryItemFound
    {
        public Entity Inventory { get; init; }
        public PrefabGUID Item { get; init; }
        public int AmountFound { get; init; }

        public InventoryItemFound(Entity inventory, PrefabGUID item, int amountFound)
        {
            Inventory = inventory;
            Item = item;
            AmountFound = amountFound;
        }
    }
}
