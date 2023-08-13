namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Contexts/EnvQueryContext_BlueprintBase.h")]
public partial class UEnvQueryContext_BlueprintBase : UEnvQueryContext {
	public static UClass StaticClass() {return default;}
	///<summary>ProvideSingleActor</summary>
	public void ProvideSingleActor(UObject QuerierObject,AActor QuerierActor,AActor ResultingActor) {}
	///<summary>ProvideSingleLocation</summary>
	public void ProvideSingleLocation(UObject QuerierObject,AActor QuerierActor,FVector ResultingLocation) {}
	///<summary>ProvideActorsSet</summary>
	public void ProvideActorsSet(UObject QuerierObject,AActor QuerierActor,TArray<AActor> ResultingActorsSet) {}
	///<summary>ProvideLocationsSet</summary>
	public void ProvideLocationsSet(UObject QuerierObject,AActor QuerierActor,TArray<FVector> ResultingLocationSet) {}
}
