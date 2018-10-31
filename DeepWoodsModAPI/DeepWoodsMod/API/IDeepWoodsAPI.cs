
using Microsoft.Xna.Framework;
using StardewValley;
using StardewValley.Monsters;
using StardewValley.TerrainFeatures;
using System;
using xTile.Dimensions;

namespace DeepWoodsMod.API
{
    public interface IDeepWoodsAPI
    {
        event Action<IDeepWoodsLocation> OnCreate;

        event Action<IDeepWoodsLocation> BeforeMapGeneration;
        event Action<IDeepWoodsLocation> AfterMapGeneration;

        event Action<IDeepWoodsLocation> BeforeFill;
        event Action<IDeepWoodsLocation> AfterFill;

        event Action<IDeepWoodsLocation> BeforeMonsterGeneration;
        event Action<IDeepWoodsLocation> AfterMonsterGeneration;

        event Action<IDeepWoodsLocation> BeforeDebrisCreation;
        event Action<IDeepWoodsLocation> AfterDebrisCreation;

        event Func<IDeepWoodsLocation, bool> OverrideMapGeneration;
        event Func<IDeepWoodsLocation, bool> OverrideFill;
        event Func<IDeepWoodsLocation, bool> OverrideMonsterGeneration;
        event Func<IDeepWoodsLocation, bool> OverrideDebrisCreation;

        void RegisterTerrainFeature(Func<IDeepWoodsLocation, Vector2, bool> decisionCallback, Func<TerrainFeature> creationCallback);
        void RegisterLargeTerrainFeature(Func<IDeepWoodsLocation, Vector2, bool> decisionCallback, Func<LargeTerrainFeature> creationCallback);
        void RegisterResourceClump(Func<IDeepWoodsLocation, Vector2, bool> decisionCallback, Func<ResourceClump> creationCallback);
        void RegisterObject(Func<IDeepWoodsLocation, Vector2, bool> decisionCallback, Func<StardewValley.Object> creationCallback);
        void RegisterMonster(Func<IDeepWoodsLocation, Vector2, bool> decisionCallback, Func<Monster> creationCallback);

        void AddDeepWoodsWarpToGameLocation(GameLocation gameLocation, Location sourceTile, string deepWoodsName, Location destinationTile, int enterDirection);
        void RemoveDeepWoodsWarpFromGameLocation(GameLocation gameLocation, Location sourceTile);
    }
}
