#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_Composite.h")]
///<summary>Composite generator allows using multiple generators in single query option</summary>
public partial class UEnvQueryGenerator_Composite : UEnvQueryGenerator {
// EnvQueryGenerator_Composite
	public TArray<UEnvQueryGenerator> Generators;
	public bool bAllowDifferentItemTypes;
	public bool bHasMatchingItemType;
	public UClass ForcedItemType;
}
