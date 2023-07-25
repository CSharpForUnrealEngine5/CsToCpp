#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>Blueprints are special assets that provide an intuitive, node-based interface that can be used to create new types of Actors</summary>
public partial class UBlueprint : UBlueprintCore {
// Blueprint
	public UClass ParentClass;
	public byte BlueprintType;
	public bool bRecompileOnLoad;
	public bool bHasBeenRegenerated;
	public bool bIsRegeneratingOnLoad;
	public bool bBeingCompiled;
	public bool bIsNewlyCreated;
	public bool bForceFullEditor;
	public bool bQueuedForCompilation;
	public bool bRunConstructionScriptOnDrag;
	public bool bRunConstructionScriptInSequencer;
	public bool bGenerateConstClass;
	public bool bGenerateAbstractClass;
	public bool bDisplayCompilePIEWarning;
	public bool bDeprecate;
	public bool bDuplicatingReadOnly;
	public EShouldCookBlueprintPropertyGuids ShouldCookPropertyGuidsValue;
	public EBlueprintNativizationFlag NativizationFlag;
	public EBlueprintCompileMode CompileMode;
	public byte Status;
	public string BlueprintDisplayName;
	public string BlueprintDescription;
	public string BlueprintNamespace;
	public string BlueprintCategory;
	public TArray<string> HideCategories;
	public int BlueprintSystemVersion;
	public USimpleConstructionScript SimpleConstructionScript;
	public TArray<UEdGraph> UbergraphPages;
	public TArray<UEdGraph> FunctionGraphs;
	public TArray<UEdGraph> DelegateSignatureGraphs;
	public TArray<UEdGraph> MacroGraphs;
	public TArray<UEdGraph> IntermediateGeneratedGraphs;
	public TArray<UEdGraph> EventGraphs;
	public TMap<UEdGraph,FBlueprintMacroCosmeticInfo> PRIVATE_CachedMacroInfo;
	public TArray<UActorComponent> ComponentTemplates;
	public TArray<UTimelineTemplate> Timelines;
	public TArray<FBPComponentClassOverride> ComponentClassOverrides;
	public UInheritableComponentHandler InheritableComponentHandler;
	public TArray<FBPVariableDescription> NewVariables;
	public TArray<string> CategorySorting;
	public TSet<string> ImportedNamespaces;
	public TArray<FBPInterfaceDescription> ImplementedInterfaces;
	public TArray<FEditedDocumentInfo> LastEditedDocuments;
	public TMap<FGuid,FEditedDocumentInfo> Bookmarks;
	public TArray<FBPEditorBookmarkNode> BookmarkNodes;
	public TArray<UDEPRECATED_Breakpoint> Breakpoints_DEPRECATED;
	public TArray<FEdGraphPinReference> WatchedPins_DEPRECATED;
	public TArray<UEdGraphPin_Deprecated> DeprecatedPinWatches;
	public TMap<string,int> ComponentTemplateNameIndex;
	public TMap<string,string> OldToNewComponentTemplateNames;
	public TArray<UBlueprintExtension> Extensions;
	public UThumbnailInfo ThumbnailInfo;
	public uint CrcLastCompiledCDO;
	public uint CrcLastCompiledSignature;
	public bool bCachedDependenciesUpToDate;
	public TSet<TWeakObjectPtr<UBlueprint>> CachedDependencies;
	public TSet<TWeakObjectPtr<UBlueprint>> CachedDependents;
	public TSet<TWeakObjectPtr<UStruct>> CachedUDSDependencies;
	public UClass OriginalClass;
}
