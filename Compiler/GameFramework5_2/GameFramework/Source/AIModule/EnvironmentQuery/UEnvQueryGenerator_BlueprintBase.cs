#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_BlueprintBase.h")]
public partial class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator {
// EnvQueryGenerator_BlueprintBase
	public string GeneratorsActionDescription;
	public UClass Context;
	public UClass GeneratedItemType;
	public void DoItemGeneration(TArray<FVector> ContextLocations) {}
	public void DoItemGenerationFromActors(TArray<UObject> ContextActors) {}
	public void AddGeneratedVector(FVector GeneratedVector) {}
	public void AddGeneratedActor(UObject GeneratedActor) {}
	public UObject GetQuerier() { return default; }
}
