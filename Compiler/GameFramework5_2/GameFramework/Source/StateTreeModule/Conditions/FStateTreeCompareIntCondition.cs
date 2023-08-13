namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Condition comparing two integers.</summary>
[CppInclude("Conditions/StateTreeCommonConditions.h")]
public partial struct FStateTreeCompareIntCondition {
	public bool bInvert;
	public EGenericAICheck Operator;
}
