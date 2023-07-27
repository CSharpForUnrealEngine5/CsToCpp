#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterLandscapeBrush.h")]
public partial class AWaterLandscapeBrush : ALandscapeBlueprintBrush {
// WaterLandscapeBrush
	public  void GetWaterBodies(UClass WaterBodyClass,TArray<AWaterBody> OutWaterBodies) {}
	public  void GetWaterBodyIslands(UClass WaterBodyIslandClass,TArray<AWaterBodyIsland> OutWaterBodyIslands) {}
	public  void GetActorsAffectingLandscape(TArray<object /*OutWaterBrushActors*/> OutWaterBrushActors) {}
	public  void BlueprintWaterBodiesChanged() {}
	public  void BlueprintWaterBodyChanged(AActor Actor) {}
	public  void SetWaterBodyCache(AWaterBody WaterBody,UObject InCache) {}
	public  UObject GetWaterBodyCache(AWaterBody WaterBody,UClass CacheClass) { return default; }
	public  void ClearWaterBodyCache(AWaterBody WaterBody) {}
	public  void SetActorCache(AActor InActor,UObject InCache) {}
	public  UObject GetActorCache(AActor InActor,UClass CacheClass) { return default; }
	public  void ClearActorCache(AActor InActor) {}
	public  void BlueprintGetRenderTargets(UTextureRenderTarget2D InHeightRenderTarget,UTextureRenderTarget2D OutVelocityRenderTarget) {}
	public  void BlueprintOnRenderTargetTexturesUpdated(UTexture2D VelocityTexture) {}
	public  void ForceWaterTextureUpdate() {}
	public UBillboardComponent ActorIcon;
	public TMap<TWeakObjectPtr<AActor>,UObject> Cache;
}
