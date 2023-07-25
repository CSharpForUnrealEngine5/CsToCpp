#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldConditionQuery.h")]
///<summary>General purpose World Condition Query that combines Query Definition and Query State in one.</summary>
public partial struct FWorldConditionQuery {
// WorldConditionQuery
	public FWorldConditionQueryDefinition QueryDefinition;
	public FWorldConditionQueryState QueryState;
}
