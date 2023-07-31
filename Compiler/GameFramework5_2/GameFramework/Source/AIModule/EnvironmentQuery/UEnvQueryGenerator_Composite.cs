#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Composite generator allows using multiple generators in single query option</summary>
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_Composite.h")]
public partial class UEnvQueryGenerator_Composite : UEnvQueryGenerator {
	///<summary>Generators</summary>
	public TArray<UEnvQueryGenerator> Generators;
	///<summary>allow generators with different item types, use at own risk!</summary>
	public bool bAllowDifferentItemTypes;
	///<summary>bHasMatchingItemType</summary>
	public bool bHasMatchingItemType;
	///<summary>ForcedItemType</summary>
	public UClass ForcedItemType;
}
