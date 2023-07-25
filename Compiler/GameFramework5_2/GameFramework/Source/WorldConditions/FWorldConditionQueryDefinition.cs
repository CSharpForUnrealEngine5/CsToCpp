#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldConditionQuery.h")]
///<summary>Definition of a world condition.</summary>
public partial struct FWorldConditionQueryDefinition {
// WorldConditionQueryDefinition
	public UWorldConditionQuerySharedDefinition SharedDefinition;
	public UClass SchemaClass;
	public TArray<FWorldConditionEditable> EditableConditions;
}
