#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_PerceivedActors.h")]
///<summary>Gathers actors perceived by context</summary>
public partial class UEnvQueryGenerator_PerceivedActors : UEnvQueryGenerator {
// EnvQueryGenerator_PerceivedActors
	public UClass AllowedActorClass;
	public FAIDataProviderFloatValue SearchRadius;
	public UClass ListenerContext;
	public UClass SenseToUse;
	public bool bIncludeKnownActors;
}
