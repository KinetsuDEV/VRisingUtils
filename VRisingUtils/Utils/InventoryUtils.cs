using ProjectM;
using System;
using System.Collections.Generic;
using Unity.Entities;
using VRisingUtils.Models;

namespace VRisingUtils.Utils
{
    public static class InventoryUtils
    {
        public static InventorySearchResult Search(Entity inventory, PrefabGUID item, int amount)
        {
            var finds = new List<InventoryItemFound>();
            var inventoryBuffer = WetstoneUtils.EntityManager.GetBuffer<InventoryBuffer>(inventory);
            var amountFound = 0;

            foreach (var inventoryItem in inventoryBuffer)
            {
                if (inventoryItem.ItemType == item)
                {
                    var amountUsed = Math.Min(inventoryItem.Stacks, amount - amountFound);
                    finds.Add(new InventoryItemFound(inventory, item, amountUsed));
                    amountFound += amountUsed;
                }

                if (amountFound >= amount)
                    break;
            }

            return new InventorySearchResult()
            {
                Item = item,
                AmountNeeded = amount,
                ItemsFound = finds
            };
        }
    }
}
