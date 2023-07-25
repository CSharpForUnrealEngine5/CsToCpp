#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Contexts/EnvQueryContext_BlueprintBase.h")]
public partial class UEnvQueryContext_BlueprintBase : UEnvQueryContext {
// EnvQueryContext_BlueprintBase
	public void ProvideSingleActor(UObject QuerierObject,UObject QuerierActor,UObject ResultingActor) {}
	public void ProvideSingleLocation(UObject QuerierObject,UObject QuerierActor,FVector ResultingLocation) {}
	public void ProvideActorsSet(UObject QuerierObject,UObject QuerierActor,TArray<UObject> ResultingActorsSet) {}
	public void ProvideLocationsSet(UObject QuerierObject,UObject QuerierActor,TArray<FVector> ResultingLocationSet) {}
}
