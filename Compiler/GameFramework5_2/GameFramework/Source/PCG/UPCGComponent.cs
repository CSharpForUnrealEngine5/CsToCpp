#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGComponent.h")]
public partial class UPCGComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetGraph</summary>
	public  void SetGraph(UPCGGraphInterface InGraph) {}
	///<summary>Registers some managed resource to the current component</summary>
	public  void AddToManagedResources(UPCGManagedResource InResource) {}
	///<summary>Starts generation from a local (vs. remote) standpoint. Will not be replicated. Will be delayed.</summary>
	public  void GenerateLocal(bool bForce) {}
	///<summary>Cleans up the generation from a local (vs. remote) standpoint. Will not be replicated. Will be delayed.</summary>
	public  void CleanupLocal(bool bRemoveComponents,bool bSave/*=false*/) {}
	///<summary>Networked generation call that also activates the component as needed</summary>
	public  void Generate(bool bForce) {}
	///<summary>Networked cleanup call</summary>
	public  void Cleanup(bool bRemoveComponents,bool bSave/*=false*/) {}
	///<summary>Notify properties changed, used in runtime cases, will dirty &amp; trigger a regeneration if needed</summary>
	public  void NotifyPropertiesChangedFromBlueprint() {}
	///<summary>Retrieves generated data</summary>
	public  FPCGDataCollection GetGeneratedGraphOutput() { return default; }
	///<summary>Move all generated resources under a new actor, following a template (AActor if not provided), clearing all link to this PCG component. Returns the new actor.</summary>
	public  AActor ClearPCGLink(UClass TemplateActor/*=nullptr*/) { return default; }
	///<summary>InputType</summary>
	public EPCGComponentInput InputType;
	///<summary>bParseActorComponents</summary>
	public bool bParseActorComponents;
	///<summary>Seed</summary>
	public int Seed;
	///<summary>bActivated</summary>
	public bool bActivated;
	///<summary>In World Partition map, will partition the component in a grid, according to PCGWorldActor settings, dispatching the generation to multiple local components.</summary>
	public bool bIsComponentPartitioned;
	///<summary>GenerationTrigger</summary>
	public EPCGComponentGenerationTrigger GenerationTrigger;
	///<summary>Flag to indicate whether this component has run in the editor. Note that for partitionable actors, this will always be false.</summary>
	public bool bGenerated;
	///<summary>bRuntimeGenerated</summary>
	public bool bRuntimeGenerated;
	///<summary>bRegenerateInEditor</summary>
	public bool bRegenerateInEditor;
	///<summary>bDirtyGenerated</summary>
	public bool bDirtyGenerated;
	///<summary>Property that will automatically be set on BP templates, to allow for &quot;Generate on add to world&quot; in editor.</summary>
	public bool bForceGenerateOnBPAddedToWorld;
	///<summary>Can specify a list of functions from the owner of this component to be called when generation is done, in order.</summary>
	public TArray<string> PostGenerateFunctionNames;
	///<summary>GraphInstance</summary>
	public UPCGGraphInstance GraphInstance;
	///<summary>Graph_DEPRECATED</summary>
	public UPCGGraph Graph_DEPRECATED;
	///<summary>Note for upgrade: can be safely replaced by bIsComponentPartitioned. Needed a new variable to change the default value. Kept to allow proper value change, cannot be deprecated. Do not use.</summary>
	public bool bIsPartitioned;
	///<summary>CachedPCGData</summary>
	public UPCGData CachedPCGData;
	///<summary>CachedInputData</summary>
	public UPCGData CachedInputData;
	///<summary>CachedActorData</summary>
	public UPCGData CachedActorData;
	///<summary>CachedLandscapeData</summary>
	public UPCGData CachedLandscapeData;
	///<summary>CachedLandscapeHeightData</summary>
	public UPCGData CachedLandscapeHeightData;
	///<summary>GeneratedActors_DEPRECATED</summary>
	public TSet<TSoftObjectPtr<AActor>> GeneratedActors_DEPRECATED;
	///<summary>GeneratedResources</summary>
	public TArray<UPCGManagedResource> GeneratedResources;
	///<summary>LastGeneratedBounds</summary>
	public FBox LastGeneratedBounds;
	///<summary>GeneratedGraphOutput</summary>
	public FPCGDataCollection GeneratedGraphOutput;
	///<summary>bIsComponentLocal</summary>
	public bool bIsComponentLocal;
	///<summary>TrackedLandscapes</summary>
	public TArray<TSoftObjectPtr<ALandscapeProxy>> TrackedLandscapes;
	///<summary>Cached tracked actors list is serialized because we can&#39;t get it at postload time</summary>
	public TSet<TWeakObjectPtr<AActor>> CachedTrackedActors;
	///<summary>InspectionCache</summary>
	public TMap<UPCGNode,FPCGDataCollection> InspectionCache;
}
