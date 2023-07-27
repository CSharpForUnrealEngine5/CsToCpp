#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDConversionBlueprintLibrary.h")]
///<summary>Wrapped static conversion functions from the UsdUtilities module, so that they can be used via scripting</summary>
public partial class UUsdConversionBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdConversionBlueprintLibrary
	public static void StreamInRequiredLevels(UWorld World,TSet<string> LevelsToIgnore) {}
	public static void RevertSequencerAnimations() {}
	public static void ReapplySequencerAnimations() {}
	public static TArray<string> GetLoadedLevelNames(UWorld World) { return default; }
	public static TArray<string> GetVisibleInEditorLevelNames(UWorld World) { return default; }
	public static void StreamOutLevels(UWorld OwningWorld,TArray<string> LevelNamesToStreamOut,TArray<string> LevelNamesToHide) {}
	public static TSet<AActor> GetActorsToConvert(UWorld World) { return default; }
	public static string GenerateObjectVersionString(UObject ObjectToExport,UObject ExportOptions) { return default; }
	public static bool CanExportToLayer(string TargetFilePath) { return default; }
	public static string MakePathRelativeToLayer(string AnchorLayerPath,string PathToMakeRelative) { return default; }
	public static void InsertSubLayer(string ParentLayerPath,string SubLayerPath,int Index/*=-1*/) {}
	public static void AddPayload(string ReferencingStagePath,string ReferencingPrimPath,string TargetStagePath) {}
	public static string GetPrimPathForObject(UObject ActorOrComponent,string ParentPrimPath/*=TEXT("")*/,bool bUseActorFolders/*=false*/) { return default; }
	public static string GetSchemaNameForComponent(USceneComponent Component) { return default; }
	public static AInstancedFoliageActor GetInstancedFoliageActorForLevel(bool bCreateIfNone/*=false*/,ULevel Level/*=nullptr*/) { return default; }
	public static TArray<UFoliageType> GetUsedFoliageTypes(AInstancedFoliageActor Actor) { return default; }
	public static UObject GetSource(UFoliageType FoliageType) { return default; }
	public static TArray<FTransform> GetInstanceTransforms(AInstancedFoliageActor Actor,UFoliageType FoliageType,ULevel InstancesLevel/*=nullptr*/) { return default; }
	public static TArray<FAnalyticsEventAttr> GetAnalyticsAttributes(ULevelExporterUSDOptions Options) { return default; }
	public static void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,string EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,string Extension) {}
	public static void RemoveAllPrimSpecs(string StageRootLayer,string PrimPath,string TargetLayer) {}
	public static bool CutPrims(string StageRootLayer,TArray<string> PrimPaths) { return default; }
	public static bool CopyPrims(string StageRootLayer,TArray<string> PrimPaths) { return default; }
	public static TArray<string> PastePrims(string StageRootLayer,string ParentPrimPath) { return default; }
	public static bool CanPastePrims() { return default; }
	public static void ClearPrimClipboard() {}
	public static TArray<string> DuplicatePrims(string StageRootLayer,TArray<string> PrimPaths,EUsdDuplicateType DuplicateType,string TargetLayer) { return default; }
}
