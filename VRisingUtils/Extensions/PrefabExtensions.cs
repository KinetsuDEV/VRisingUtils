using ProjectM;
using Unity.Entities;
using VRisingUtils.Utils;

namespace VRisingUtils.Extensions
{
    public static class PrefabExtensions
    {
        public static Entity GetEntity(this PrefabGUID prefab) => WetstoneUtils.PrefabLookupMap[prefab];

        public static string GetName(this PrefabGUID prefab)
        {
            if (prefab.IsEmpty())
                return "PrefabIsEmpty";

            if (!WetstoneUtils.PrefabNameLookupMap.ContainsKey(prefab))
                return "PrefabHasNoName";

            return WetstoneUtils.PrefabNameLookupMap[prefab].ToString();
        }
    }
}
