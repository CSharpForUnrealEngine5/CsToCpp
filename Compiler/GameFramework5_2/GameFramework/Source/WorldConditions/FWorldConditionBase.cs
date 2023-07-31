#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for all World Conditions.</summary>
[CppInclude("WorldConditionBase.h")]
public partial struct FWorldConditionBase {
	public bool bInvert;
	public EWorldConditionOperator Operator;
	public byte NextExpressionDepth;
}
