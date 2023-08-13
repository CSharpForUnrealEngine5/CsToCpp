namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Condition comparing two floats.</summary>
[CppInclude("Conditions/StateTreeCommonConditions.h")]
public partial struct FStateTreeCompareFloatCondition {
	public bool bInvert;
	public EGenericAICheck Operator;
}
