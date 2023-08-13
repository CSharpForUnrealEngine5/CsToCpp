namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of functions that can be used via Python scripting to help export Unreal scenes and assets to USD</summary>
[CppInclude("USDExporterBlueprintLibrary.h")]
public partial class UUsdExporterBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetInstancedFoliageActorForLevel</summary>
	public static AInstancedFoliageActor GetInstancedFoliageActorForLevel(bool bCreateIfNone/*=false*/,ULevel Level/*=nullptr*/) { return default; }
	///<summary>GetUsedFoliageTypes</summary>
	public static TArray<UFoliageType> GetUsedFoliageTypes(AInstancedFoliageActor Actor) { return default; }
	///<summary>GetSource</summary>
	public static UObject GetSource(UFoliageType FoliageType) { return default; }
	///<summary>GetInstanceTransforms</summary>
	public static TArray<FTransform> GetInstanceTransforms(AInstancedFoliageActor Actor,UFoliageType FoliageType,ULevel InstancesLevel/*=nullptr*/) { return default; }
	///<summary>SendAnalytics</summary>
	public static void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,string EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,string Extension) {}
}
