using ProjectM;
using Unity.Collections;
using Unity.Entities;
using Wetstone.API;

namespace VRisingUtils.Utils
{
    public static class WetstoneUtils
    {
        public static World World => VWorld.IsServer ? VWorld.Server : VWorld.Client;
        public static EntityManager EntityManager => World.EntityManager;
        public static GameDataSystem GameDataSystem => World.GetExistingSystem<GameDataSystem>();

        public static PrefabCollectionSystem PrefabCollectionSystem => World.GetExistingSystem<PrefabCollectionSystem>();
        public static NativeHashMap<PrefabGUID, Entity> PrefabLookupMap => PrefabCollectionSystem.PrefabLookupMap;
        public static NativeHashMap<PrefabGUID, FixedString128> PrefabNameLookupMap => PrefabCollectionSystem.PrefabNameLookupMap;
    }
}
