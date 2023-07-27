#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDExporterBlueprintLibrary.h")]
///<summary>Library of functions that can be used via Python scripting to help export Unreal scenes and assets to USD</summary>
public partial class UUsdExporterBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdExporterBlueprintLibrary
	public static AInstancedFoliageActor GetInstancedFoliageActorForLevel(bool bCreateIfNone/*=false*/,ULevel Level/*=nullptr*/) { return default; }
	public static TArray<UFoliageType> GetUsedFoliageTypes(AInstancedFoliageActor Actor) { return default; }
	public static UObject GetSource(UFoliageType FoliageType) { return default; }
	public static TArray<FTransform> GetInstanceTransforms(AInstancedFoliageActor Actor,UFoliageType FoliageType,ULevel InstancesLevel/*=nullptr*/) { return default; }
	public static void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,string EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,string Extension) {}
}
