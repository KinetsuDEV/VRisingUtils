using ProjectM;
using System.Collections.Generic;
using System.Linq;

namespace VRisingUtils.Models
{
    public class InventorySearchResult
    {
        public PrefabGUID Item { get; init; }
        public int AmountNeeded { get; init; }
        public IEnumerable<InventoryItemFound> ItemsFound { get; init; }

        public int AmountFound => ItemsFound?.Sum(i => i.AmountFound) ?? 0;
        public bool FoundAll => AmountFound >= AmountNeeded;

        public static bool AllItemsWhereFound(IEnumerable<InventorySearchResult> results)
        {
            var itemsGuid = results.Select(result => result.Item.GuidHash).Distinct();

            // Check if all items have at least one occurrence of "FoundAll" on result list
            return itemsGuid.All(itemGuid => results.Any(r => r.Item.GuidHash == itemGuid && r.FoundAll));
        }
    }
}
