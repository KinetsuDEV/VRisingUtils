using ProjectM;
using Unity.Entities;
using VRisingUtils.Extensions;

namespace VRisingUtils.Utils
{
    public static class ItemUtils
    {
        public static string GetItemName(PrefabGUID prefab) => GetItemName(prefab.GetEntity());

        public static string GetItemName(Entity entity)
        {
            if (!WetstoneUtils.EntityManager.HasComponent<ItemData>(entity))
                return "EntityHasNoItemData";

            return WetstoneUtils.EntityManager.GetComponentData<ItemData>(entity).GetName();
        }

        public static string GetRecipeItemName(PrefabGUID recipe)
        {
            var recipeOutputs = WetstoneUtils.EntityManager.GetBuffer<RecipeOutputBuffer>(recipe.GetEntity());

            if (recipeOutputs.IsEmpty)
                return "RecipeHasNoOutput";

            return GetItemName(recipeOutputs[0].Guid);
        }
    }
}
