namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>General purpose World Condition Query that combines Query Definition and Query State in one.</summary>
[CppInclude("WorldConditionQuery.h")]
public partial struct FWorldConditionQuery {
	public FWorldConditionQueryDefinition QueryDefinition;
	public FWorldConditionQueryState QueryState;
}
