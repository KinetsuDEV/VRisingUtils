using ProjectM;
using Unity.Entities;
using VRisingUtils.Utils;

namespace VRisingUtils.Extensions
{
    public static class EntityExtensions
    {
        public static PrefabGUID GetPrefab(this Entity entity)
        {
            return WetstoneUtils.World.EntityManager.HasComponent<PrefabGUID>(entity)
                ? WetstoneUtils.World.EntityManager.GetComponentData<PrefabGUID>(entity)
                : PrefabGUID.Empty;
        }

        public static string GetName(this Entity entity) => entity.GetPrefab().GetName();
    }
}
