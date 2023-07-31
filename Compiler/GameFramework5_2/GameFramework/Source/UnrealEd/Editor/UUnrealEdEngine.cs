#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/UnrealEdEngine.h")]
public partial class UUnrealEdEngine : UEditorEngine {
	///<summary>Global instance of the editor options class.</summary>
	public UUnrealEdOptions EditorOptionsInst;
	///<summary>Manager responsible for configuring auto reimport</summary>
	public UAutoReimportManager AutoReimportManager;
	///<summary>A buffer for implementing material expression copy/paste.</summary>
	public UMaterial MaterialCopyPasteBuffer;
	///<summary>A buffer for implementing sound cue nodes copy/paste.</summary>
	public USoundCue SoundCueCopyPasteBuffer;
	///<summary>Global list of instanced animation compression algorithms.</summary>
	public TArray<UAnimCompress> AnimationCompressionAlgorithms;
	///<summary>Array of packages to be fully loaded at Editor startup.</summary>
	public TArray<string> PackagesToBeFullyLoadedAtStartup;
	///<summary>Current target for LOD parenting operations (actors will use this as the replacement)</summary>
	public AActor CurrentLODParentActor;
	///<summary>Whether the user needs to be prompted about a package being saved with an engine version newer than the current one or not</summary>
	public bool bNeedWarningForPkgEngineVer;
	///<summary>Array of sorted, localized editor sprite categories</summary>
	public TArray<string> SortedSpriteCategories_DEPRECATED;
	///<summary>List of info for all known template maps</summary>
	public TArray<FTemplateMapInfo> TemplateMapInfos;
	///<summary>Cooker server incase we want to cook on the side while editing...</summary>
	public UCookOnTheFlyServer CookServer;
	///<summary>When deleting actors, these types should not generate warnings when references will be broken (this should only be types that don&#39;t affect gameplay)</summary>
	public TArray<UClass> ClassesToIgnoreDeleteReferenceWarning;
}
