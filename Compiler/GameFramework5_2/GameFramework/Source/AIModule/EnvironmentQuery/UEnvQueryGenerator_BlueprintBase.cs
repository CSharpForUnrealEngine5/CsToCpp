#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_BlueprintBase.h")]
public partial class UEnvQueryGenerator_BlueprintBase : UEnvQueryGenerator {
	public static UClass StaticClass() {return default;}
	///<summary>A short description of what test does, like &quot;Generate pawn named Joe&quot;</summary>
	public string GeneratorsActionDescription;
	///<summary>context</summary>
	public UClass Context;
	///<summary>@todo this should show up only in the generator&#39;s BP, but</summary>
	public UClass GeneratedItemType;
	///<summary>DoItemGeneration</summary>
	public  void DoItemGeneration(TArray<FVector> ContextLocations) {}
	///<summary>DoItemGenerationFromActors</summary>
	public  void DoItemGenerationFromActors(TArray<AActor> ContextActors) {}
	///<summary>AddGeneratedVector</summary>
	public  void AddGeneratedVector(FVector GeneratedVector) {}
	///<summary>AddGeneratedActor</summary>
	public  void AddGeneratedActor(AActor GeneratedActor) {}
	///<summary>GetQuerier</summary>
	public  UObject GetQuerier() { return default; }
}
