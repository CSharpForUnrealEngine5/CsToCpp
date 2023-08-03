#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterLandscapeBrush.h")]
public partial class AWaterLandscapeBrush : ALandscapeBlueprintBrush {
	public static UClass StaticClass() {return default;}
	///<summary>GetWaterBodies</summary>
	public  void GetWaterBodies(UClass WaterBodyClass,TArray<AWaterBody> OutWaterBodies) {}
	///<summary>GetWaterBodyIslands</summary>
	public  void GetWaterBodyIslands(UClass WaterBodyIslandClass,TArray<AWaterBodyIsland> OutWaterBodyIslands) {}
	///<summary>GetActorsAffectingLandscape</summary>
	public  void GetActorsAffectingLandscape(TArray<object /*OutWaterBrushActors*/> OutWaterBrushActors) {}
	///<summary>BlueprintWaterBodiesChanged</summary>
	public  void BlueprintWaterBodiesChanged() {}
	///<summary>BlueprintWaterBodyChanged</summary>
	public  void BlueprintWaterBodyChanged(AActor Actor) {}
	///<summary>SetWaterBodyCache</summary>
	public  void SetWaterBodyCache(AWaterBody WaterBody,UObject InCache) {}
	///<summary>GetWaterBodyCache</summary>
	public  UObject GetWaterBodyCache(AWaterBody WaterBody,UClass CacheClass) { return default; }
	///<summary>ClearWaterBodyCache</summary>
	public  void ClearWaterBodyCache(AWaterBody WaterBody) {}
	///<summary>SetActorCache</summary>
	public  void SetActorCache(AActor InActor,UObject InCache) {}
	///<summary>GetActorCache</summary>
	public  UObject GetActorCache(AActor InActor,UClass CacheClass) { return default; }
	///<summary>ClearActorCache</summary>
	public  void ClearActorCache(AActor InActor) {}
	///<summary>BlueprintGetRenderTargets</summary>
	public  void BlueprintGetRenderTargets(UTextureRenderTarget2D InHeightRenderTarget,UTextureRenderTarget2D OutVelocityRenderTarget) {}
	///<summary>BlueprintOnRenderTargetTexturesUpdated</summary>
	public  void BlueprintOnRenderTargetTexturesUpdated(UTexture2D VelocityTexture) {}
	///<summary>ForceWaterTextureUpdate</summary>
	public  void ForceWaterTextureUpdate() {}
	///<summary>ActorIcon</summary>
	public UBillboardComponent ActorIcon;
	///<summary>Cache</summary>
	public TMap<TWeakObjectPtr<AActor>,UObject> Cache;
}
