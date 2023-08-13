namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Condition comparing distance between two vectors.</summary>
[CppInclude("Conditions/StateTreeCommonConditions.h")]
public partial struct FStateTreeCompareDistanceCondition {
	public bool bInvert;
	public EGenericAICheck Operator;
}
