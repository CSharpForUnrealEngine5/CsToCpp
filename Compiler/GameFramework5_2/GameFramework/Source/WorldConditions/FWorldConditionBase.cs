namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for all World Conditions.</summary>
[CppInclude("WorldConditionBase.h")]
public partial struct FWorldConditionBase {
	public bool bInvert;
	public EWorldConditionOperator Operator;
	public byte NextExpressionDepth;
}
