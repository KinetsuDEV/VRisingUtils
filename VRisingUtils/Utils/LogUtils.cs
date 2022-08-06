using BepInEx.Logging;
using Unity.Entities;
using VRisingUtils.Extensions;

namespace VRisingUtils.Utils
{
    public static class LogUtils
    {
        public static ManualLogSource Logger { get; private set; }

        public static void Initialize(ManualLogSource logger) => Logger = logger;

        internal static void DumpComponents(Entity entity)
        {
            Logger.LogInfo($"--------------------------------------------------");
            Logger.LogInfo($"Dumping components of {entity.GetName()}:");

            foreach (var componentType in WetstoneUtils.EntityManager.GetComponentTypes(entity))
                Logger.LogInfo($"{componentType.ToString()}");

            Logger.LogInfo($"--------------------------------------------------");
        }
    }
}
