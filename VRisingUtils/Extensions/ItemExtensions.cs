using ProjectM;
using VRisingUtils.Utils;

namespace VRisingUtils.Extensions
{
    public static class ItemExtensions
    {
        public static ManagedItemData GetManagedData(this ItemData itemData) =>
            WetstoneUtils.GameDataSystem.ManagedDataRegistry.GetOrDefault<ManagedItemData>(itemData.ItemTypeGUID);

        public static string GetName(this ItemData itemData) =>
            itemData.GetManagedData().Name.IsEmpty ? null : itemData.GetManagedData().Name.ToString();
    }
}
