namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapped static conversion functions from the UsdUtilities module, so that they can be used via scripting</summary>
[CppInclude("USDConversionBlueprintLibrary.h")]
public partial class UUsdConversionBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Fully streams in and displays all levels whose names are not in LevelsToIgnore</summary>
	public static void StreamInRequiredLevels(UWorld World,TSet<string> LevelsToIgnore) {}
	///<summary>If we have the Sequencer open with a level sequence animating the level before export, this function can revert</summary>
	public static void RevertSequencerAnimations() {}
	///<summary>If we used `ReverseSequencerAnimations` to undo the effect of an opened sequencer before export, this function</summary>
	public static void ReapplySequencerAnimations() {}
	///<summary>Returns the path name (e.g. &quot;/Game/Maps/MyLevel&quot;) of levels that are loaded on `World`.</summary>
	public static TArray<string> GetLoadedLevelNames(UWorld World) { return default; }
	///<summary>Returns the path name (e.g. &quot;/Game/Maps/MyLevel&quot;) of levels that checked to be visible in the editor within `World`.</summary>
	public static TArray<string> GetVisibleInEditorLevelNames(UWorld World) { return default; }
	///<summary>Streams out/hides sublevels that were streamed in before export</summary>
	public static void StreamOutLevels(UWorld OwningWorld,TArray<string> LevelNamesToStreamOut,TArray<string> LevelNamesToHide) {}
	///<summary>GetActorsToConvert</summary>
	public static TSet<AActor> GetActorsToConvert(UWorld World) { return default; }
	///<summary>Generates a unique identifier string that involves ObjectToExport&#39;s package&#39;s persistent guid, the</summary>
	public static string GenerateObjectVersionString(UObject ObjectToExport,UObject ExportOptions) { return default; }
	///<summary>Checks whether we can create a USD Layer with &quot;TargetFilePath&quot; as identifier and export to it</summary>
	public static bool CanExportToLayer(string TargetFilePath) { return default; }
	///<summary>MakePathRelativeToLayer</summary>
	public static string MakePathRelativeToLayer(string AnchorLayerPath,string PathToMakeRelative) { return default; }
	///<summary>InsertSubLayer</summary>
	public static void InsertSubLayer(string ParentLayerPath,string SubLayerPath,int Index/*=-1*/) {}
	///<summary>AddPayload</summary>
	public static void AddPayload(string ReferencingStagePath,string ReferencingPrimPath,string TargetStagePath) {}
	///<summary>GetPrimPathForObject</summary>
	public static string GetPrimPathForObject(UObject ActorOrComponent,string ParentPrimPath/*=TEXT("")*/,bool bUseActorFolders/*=false*/) { return default; }
	///<summary>GetSchemaNameForComponent</summary>
	public static string GetSchemaNameForComponent(USceneComponent Component) { return default; }
	///<summary>Wraps AInstancedFoliageActor::GetInstancedFoliageActorForLevel, and allows retrieving the current AInstancedFoliageActor</summary>
	public static AInstancedFoliageActor GetInstancedFoliageActorForLevel(bool bCreateIfNone/*=false*/,ULevel Level/*=nullptr*/) { return default; }
	///<summary>Returns all the different types of UFoliageType assets that a particular AInstancedFoliageActor uses.</summary>
	public static TArray<UFoliageType> GetUsedFoliageTypes(AInstancedFoliageActor Actor) { return default; }
	///<summary>Returns the source asset for a UFoliageType.</summary>
	public static UObject GetSource(UFoliageType FoliageType) { return default; }
	///<summary>Returns the transforms of all instances of a particular UFoliageType on a given level. If no level is provided all instances will be returned.</summary>
	public static TArray<FTransform> GetInstanceTransforms(AInstancedFoliageActor Actor,UFoliageType FoliageType,ULevel InstancesLevel/*=nullptr*/) { return default; }
	///<summary>Retrieves the analytics attributes to send for the provided options object</summary>
	public static TArray<FAnalyticsEventAttr> GetAnalyticsAttributes(ULevelExporterUSDOptions Options) { return default; }
	///<summary>Defer to the USDClasses module to actually send analytics information</summary>
	public static void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,string EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,string Extension) {}
	///<summary>Removes all the prim specs for Prim on the given Layer.</summary>
	public static void RemoveAllPrimSpecs(string StageRootLayer,string PrimPath,string TargetLayer) {}
	///<summary>Copies flattened versions of the input prims onto the clipboard stage and removes all the prim specs for Prims from their stages.</summary>
	public static bool CutPrims(string StageRootLayer,TArray<string> PrimPaths) { return default; }
	///<summary>Copies flattened versions of the input prims onto the clipboard stage.</summary>
	public static bool CopyPrims(string StageRootLayer,TArray<string> PrimPaths) { return default; }
	///<summary>Pastes the prims from the clipboard stage as children of ParentPrim.</summary>
	public static TArray<string> PastePrims(string StageRootLayer,string ParentPrimPath) { return default; }
	///<summary>Returns true if we have prims that we can paste within our clipboard stage</summary>
	public static bool CanPastePrims() { return default; }
	///<summary>Clears all prims from our clipboard stage</summary>
	public static void ClearPrimClipboard() {}
	///<summary>Duplicates all provided Prims one-by-one, performing the requested DuplicateType.</summary>
	public static TArray<string> DuplicatePrims(string StageRootLayer,TArray<string> PrimPaths,EUsdDuplicateType DuplicateType,string TargetLayer) { return default; }
}
