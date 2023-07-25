#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterLandscapeBrush.h")]
public partial class AWaterLandscapeBrush : ALandscapeBlueprintBrush {
// WaterLandscapeBrush
	public void GetWaterBodies(UClass WaterBodyClass,TArray<UObject> OutWaterBodies) {}
	public void GetWaterBodyIslands(UClass WaterBodyIslandClass,TArray<UObject> OutWaterBodyIslands) {}
	public void GetActorsAffectingLandscape(TArray<object /*OutWaterBrushActors*/> OutWaterBrushActors) {}
	public void BlueprintWaterBodiesChanged() {}
	public void BlueprintWaterBodyChanged(UObject Actor) {}
	public void SetWaterBodyCache(UObject WaterBody,UObject InCache) {}
	public UObject GetWaterBodyCache(UObject WaterBody,UClass CacheClass) { return default; }
	public void ClearWaterBodyCache(UObject WaterBody) {}
	public void SetActorCache(UObject InActor,UObject InCache) {}
	public UObject GetActorCache(UObject InActor,UClass CacheClass) { return default; }
	public void ClearActorCache(UObject InActor) {}
	public void BlueprintGetRenderTargets(UObject InHeightRenderTarget,UObject OutVelocityRenderTarget) {}
	public void BlueprintOnRenderTargetTexturesUpdated(UObject VelocityTexture) {}
	public void ForceWaterTextureUpdate() {}
	public UBillboardComponent ActorIcon;
	public TMap<TWeakObjectPtr<AActor>,UObject> Cache;
}
