#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDConversionBlueprintLibrary.h")]
///<summary>Wrapped static conversion functions from the UsdUtilities module, so that they can be used via scripting</summary>
public partial class UUsdConversionBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdConversionBlueprintLibrary
	public void StreamInRequiredLevels(UObject World,TSet<string> LevelsToIgnore) {}
	public void RevertSequencerAnimations() {}
	public void ReapplySequencerAnimations() {}
	public TArray<string> GetLoadedLevelNames(UObject World) { return default; }
	public TArray<string> GetVisibleInEditorLevelNames(UObject World) { return default; }
	public void StreamOutLevels(UObject OwningWorld,TArray<string> LevelNamesToStreamOut,TArray<string> LevelNamesToHide) {}
	public TSet<UObject> GetActorsToConvert(UObject World) { return default; }
	public string GenerateObjectVersionString(UObject ObjectToExport,UObject ExportOptions) { return default; }
	public bool CanExportToLayer(string TargetFilePath) { return default; }
	public string MakePathRelativeToLayer(string AnchorLayerPath,string PathToMakeRelative) { return default; }
	public void InsertSubLayer(string ParentLayerPath,string SubLayerPath,int Index/*=-1*/) {}
	public void AddPayload(string ReferencingStagePath,string ReferencingPrimPath,string TargetStagePath) {}
	public string GetPrimPathForObject(UObject ActorOrComponent,string ParentPrimPath/*=TEXT("")*/,bool bUseActorFolders/*=false*/) { return default; }
	public string GetSchemaNameForComponent(UObject Component) { return default; }
	public UObject GetInstancedFoliageActorForLevel(bool bCreateIfNone/*=false*/,UObject Level/*=nullptr*/) { return default; }
	public TArray<UObject> GetUsedFoliageTypes(UObject Actor) { return default; }
	public UObject GetSource(UObject FoliageType) { return default; }
	public TArray<FTransform> GetInstanceTransforms(UObject Actor,UObject FoliageType,UObject InstancesLevel/*=nullptr*/) { return default; }
	public TArray<FAnalyticsEventAttr> GetAnalyticsAttributes(UObject Options) { return default; }
	public void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,string EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,string Extension) {}
	public void RemoveAllPrimSpecs(string StageRootLayer,string PrimPath,string TargetLayer) {}
	public bool CutPrims(string StageRootLayer,TArray<string> PrimPaths) { return default; }
	public bool CopyPrims(string StageRootLayer,TArray<string> PrimPaths) { return default; }
	public TArray<string> PastePrims(string StageRootLayer,string ParentPrimPath) { return default; }
	public bool CanPastePrims() { return default; }
	public void ClearPrimClipboard() {}
	public TArray<string> DuplicatePrims(string StageRootLayer,TArray<string> PrimPaths,EUsdDuplicateType DuplicateType,string TargetLayer) { return default; }
}
