#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gathers actors perceived by context</summary>
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_PerceivedActors.h")]
public partial class UEnvQueryGenerator_PerceivedActors : UEnvQueryGenerator {
	///<summary>If set will be used to filter results</summary>
	public UClass AllowedActorClass;
	///<summary>Additional distance limit imposed on the items generated. Perception&#39;s range limit still applies.</summary>
	public FAIDataProviderFloatValue SearchRadius;
	///<summary>The perception listener to use as a source of information</summary>
	public UClass ListenerContext;
	///<summary>If set will be used to filter gathered results so that only actors perceived with a given sense are considered</summary>
	public UClass SenseToUse;
	///<summary>Indicates whether to include all actors known via perception (TRUE) or just the ones actively being perceived</summary>
	public bool bIncludeKnownActors;
}
