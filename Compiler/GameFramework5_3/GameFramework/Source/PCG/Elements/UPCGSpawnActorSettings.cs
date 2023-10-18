namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* PCG settings class that allows spawning actors with some options to perform the work more efficiently.</summary>
[CppInclude("Elements/PCGSpawnActor.h")]
public partial class UPCGSpawnActorSettings : UPCGBaseSubgraphSettings {
	public static UClass StaticClass() {return default;}
	///<summary>TemplateActorClass</summary>
	public UClass TemplateActorClass;
	///<summary>Can specify a list of functions from the template class to be called on each actor spawned, in order. Need to be parameter-less and with &quot;CallInEditor&quot; flag enabled.</summary>
	public TArray<FName> PostSpawnFunctionNames;
	///<summary>Option</summary>
	public EPCGSpawnActorOption Option;
	///<summary>bForceDisableActorParsing</summary>
	public bool bForceDisableActorParsing;
	///<summary>GenerationTrigger</summary>
	public EPCGSpawnActorGenerationTrigger GenerationTrigger;
	///<summary>Warning: inheriting parent actor tags work only in non-collapsed actor hierarchies</summary>
	public bool bInheritActorTags;
	///<summary>TagsToAddOnActors</summary>
	public TArray<FName> TagsToAddOnActors;
	///<summary>bAllowTemplateActorEditing</summary>
	public bool bAllowTemplateActorEditing;
	///<summary>TemplateActor</summary>
	public AActor TemplateActor;
	///<summary>ActorOverrides</summary>
	public TArray<FPCGActorPropertyOverride> ActorOverrides;
	///<summary>RootActor</summary>
	public TSoftObjectPtr<AActor> RootActor;
	///<summary>AttachOptions</summary>
	public EPCGAttachOptions AttachOptions;
	///<summary>bSpawnByAttribute</summary>
	public bool bSpawnByAttribute;
	///<summary>SpawnAttribute</summary>
	public FName SpawnAttribute;
	///<summary>bGenerationTrigger_DEPRECATED</summary>
	public EPCGSpawnActorGenerationTrigger bGenerationTrigger_DEPRECATED;
}
