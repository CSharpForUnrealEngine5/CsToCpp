#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDExporterBlueprintLibrary.h")]
///<summary>Library of functions that can be used via Python scripting to help export Unreal scenes and assets to USD</summary>
public partial class UUsdExporterBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdExporterBlueprintLibrary
	public UObject GetInstancedFoliageActorForLevel(bool bCreateIfNone/*=false*/,UObject Level/*=nullptr*/) { return default; }
	public TArray<UObject> GetUsedFoliageTypes(UObject Actor) { return default; }
	public UObject GetSource(UObject FoliageType) { return default; }
	public TArray<FTransform> GetInstanceTransforms(UObject Actor,UObject FoliageType,UObject InstancesLevel/*=nullptr*/) { return default; }
	public void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,string EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,string Extension) {}
}
