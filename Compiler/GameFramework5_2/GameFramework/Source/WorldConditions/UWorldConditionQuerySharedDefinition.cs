namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that describes a specific configuration of a world condition. Should not be used directly.</summary>
[CppInclude("WorldConditionQuery.h")]
public partial class UWorldConditionQuerySharedDefinition : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>All the conditions of the world conditions.</summary>
	public FInstancedStructContainer Conditions;
	///<summary>Schema used to create the conditions.</summary>
	public UClass SchemaClass;
}
