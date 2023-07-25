#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGComponent.h")]
public partial class UPCGComponent : UActorComponent {
// PCGComponent
	public void SetGraph(UObject InGraph) {}
	public void AddToManagedResources(UObject InResource) {}
	public void GenerateLocal(bool bForce) {}
	public void CleanupLocal(bool bRemoveComponents,bool bSave/*=false*/) {}
	public void Generate(bool bForce) {}
	public void Cleanup(bool bRemoveComponents,bool bSave/*=false*/) {}
	public void NotifyPropertiesChangedFromBlueprint() {}
	public FPCGDataCollection GetGeneratedGraphOutput() { return default; }
	public UObject ClearPCGLink(UClass TemplateActor/*=nullptr*/) { return default; }
	public EPCGComponentInput InputType;
	public bool bParseActorComponents;
	public int Seed;
	public bool bActivated;
	public bool bIsComponentPartitioned;
	public EPCGComponentGenerationTrigger GenerationTrigger;
	public bool bGenerated;
	public bool bRuntimeGenerated;
	public bool bRegenerateInEditor;
	public bool bDirtyGenerated;
	public bool bForceGenerateOnBPAddedToWorld;
	public TArray<string> PostGenerateFunctionNames;
	public UPCGGraphInstance GraphInstance;
	public UPCGGraph Graph_DEPRECATED;
	public bool bIsPartitioned;
	public UPCGData CachedPCGData;
	public UPCGData CachedInputData;
	public UPCGData CachedActorData;
	public UPCGData CachedLandscapeData;
	public UPCGData CachedLandscapeHeightData;
	public TSet<TSoftObjectPtr<AActor>> GeneratedActors_DEPRECATED;
	public TArray<UPCGManagedResource> GeneratedResources;
	public FBox LastGeneratedBounds;
	public FPCGDataCollection GeneratedGraphOutput;
	public bool bIsComponentLocal;
	public TArray<TSoftObjectPtr<ALandscapeProxy>> TrackedLandscapes;
	public TSet<TWeakObjectPtr<AActor>> CachedTrackedActors;
	public TMap<UPCGNode,FPCGDataCollection> InspectionCache;
}
