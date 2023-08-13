namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Definition of a world condition.</summary>
[CppInclude("WorldConditionQuery.h")]
public partial struct FWorldConditionQueryDefinition {
	public UWorldConditionQuerySharedDefinition SharedDefinition;
	public UClass SchemaClass;
	public TArray<FWorldConditionEditable> EditableConditions;
}
