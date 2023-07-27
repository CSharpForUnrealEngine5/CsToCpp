#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Contexts/EnvQueryContext_BlueprintBase.h")]
public partial class UEnvQueryContext_BlueprintBase : UEnvQueryContext {
// EnvQueryContext_BlueprintBase
	public  void ProvideSingleActor(UObject QuerierObject,AActor QuerierActor,AActor ResultingActor) {}
	public  void ProvideSingleLocation(UObject QuerierObject,AActor QuerierActor,FVector ResultingLocation) {}
	public  void ProvideActorsSet(UObject QuerierObject,AActor QuerierActor,TArray<AActor> ResultingActorsSet) {}
	public  void ProvideLocationsSet(UObject QuerierObject,AActor QuerierActor,TArray<FVector> ResultingLocationSet) {}
}
