#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/UnrealEdEngine.h")]
public partial class UUnrealEdEngine : UEditorEngine {
// UnrealEdEngine
	public UUnrealEdOptions EditorOptionsInst;
	public UAutoReimportManager AutoReimportManager;
	public UMaterial MaterialCopyPasteBuffer;
	public USoundCue SoundCueCopyPasteBuffer;
	public TArray<UAnimCompress> AnimationCompressionAlgorithms;
	public TArray<string> PackagesToBeFullyLoadedAtStartup;
	public AActor CurrentLODParentActor;
	public bool bNeedWarningForPkgEngineVer;
	public TArray<string> SortedSpriteCategories_DEPRECATED;
	public TArray<FTemplateMapInfo> TemplateMapInfos;
	public UCookOnTheFlyServer CookServer;
	public TArray<UClass> ClassesToIgnoreDeleteReferenceWarning;
}
