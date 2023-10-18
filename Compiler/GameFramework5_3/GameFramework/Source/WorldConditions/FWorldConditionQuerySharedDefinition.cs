namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that describes a specific configuration of a world condition. Should not be used directly.</summary>
[CppInclude("WorldConditionQuery.h")]
public partial struct FWorldConditionQuerySharedDefinition {
	public FInstancedStructContainer Conditions;
	public UClass SchemaClass;
}
