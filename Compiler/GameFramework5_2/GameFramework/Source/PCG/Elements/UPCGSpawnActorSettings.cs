#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSpawnActor.h")]
public partial class UPCGSpawnActorSettings : UPCGBaseSubgraphSettings {
	///<summary>TemplateActorClass</summary>
	public UClass TemplateActorClass;
	///<summary>Can specify a list of functions from the template class to be called on each actor spawned, in order. Need to be parameter-less and with &quot;CallInEditor&quot; flag enabled.</summary>
	public TArray<string> PostSpawnFunctionNames;
	///<summary>Option</summary>
	public EPCGSpawnActorOption Option;
	///<summary>bForceDisableActorParsing</summary>
	public bool bForceDisableActorParsing;
	///<summary>bGenerationTrigger</summary>
	public EPCGSpawnActorGenerationTrigger bGenerationTrigger;
	///<summary>Warning: inheriting parent actor tags work only in non-collapsed actor hierarchies</summary>
	public bool bInheritActorTags;
	///<summary>TagsToAddOnActors</summary>
	public TArray<string> TagsToAddOnActors;
	///<summary>TemplateActor</summary>
	public AActor TemplateActor;
	///<summary>ActorOverrides</summary>
	public TArray<FPCGActorPropertyOverride> ActorOverrides;
}
